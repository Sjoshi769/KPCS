using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace KatpotCS
{
    enum WirelessMonitorStatus
    {
        SERIAL_PORT_SUCCESS = 0,
        SERIAL_PORT_UNINITIALIZED,
        SERIAL_PORT_WRITE_TIMEOUT,
        SERIAL_PORT_READTIMEOUT,
        SERIAL_PORT_INVALID_RESPONSE,
        SERIAL_PORT_NOT_DETECTED,
        SERIAL_PORT_AUTHORIZATION_ERROR,
        SERIAL_PORT_INVALID_NAME_ERROR,
        SERIAL_PORT_ARGUMENT_ERROR,
        SERIAL_PORT_IO_ERROR,
        SERIAL_PORT_ALREADY_OPEN_ERROR,
        SERIAL_PORT_SYNC_LOST,
    };

    public static class Constants
    {
        public const int SERIAL_PORT_BAUDRATE_VAL = 9600;
        public const int SERIAL_PORT_DATA_BITS_VAL = 8;
        public const int SERIAL_PORT_READ_TIMEOUT_VAL = 500;
        public const int SERIAL_PORT_WRITE_TIMEOUT_VAL = 500;
        public const int SERIAL_PORT_READ_TIMEOUT_SYNC_VAL = 1000;
        public const int MAX_SYNC_BYTES = 50;
        public const int SERIAL_PORT_SUCCESS = 0;
        public const int SERIAL_PORT_PACKET_SIZE = 6;
        public const int MAX_NUM_TESTS = 3;
        public const int MAX_COMM_PORTS_IN_SYSTEM = 5;
        public const int NUM_CH_TO_SHOW = 6;
        public const int PACKET_COUNT_THRESHOLD = 15;
        public const int MAX_NUM_SAMPLES = 5*1000;
    }

    static class Program
    {

        static Form1 main_form;
        static bool SimulateSerialPort = true;
        static int Val = 0;
        static int SuccessCount = 0;
        static int[] DirectionFlag = { 0, 0, 0, 0, 0, 0 };
        static int[] PacketCount = { 0, 0, 0, 0, 0, 0 };
        static bool AveragingStarted = false;
        static int TestCount = 0;
        static int[] NumSamples;
        //gcroot<array<array<int>^>^> SampleArray;
        static int[][] SampleArray;
        static int[] NewLoadValues;
        static KPSerialPort MySerialObj;


        static void newFormThread()
        {
           
            Application.Run(main_form);
        }

        static int AsciiToInt(byte[] SerialPortReadArray, int offset)
        {

            return (SerialPortReadArray[offset] - (byte)'0') * 100000 + (SerialPortReadArray[offset + 1] - (byte)'0') * 10000 + 
								(SerialPortReadArray[offset + 2] - (byte)'0') * 1000 + (SerialPortReadArray[offset + 3] - (byte)'0') * 100 + 
								(SerialPortReadArray[offset + 4] - (byte)'0') * 10 + (SerialPortReadArray[offset + 5] - (byte)'0');

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Thread^ serialPortReadThread;
            //Thread^ serialPortWriteThread;

            byte[] SerialPortReadArray;
            int status = (int) WirelessMonitorStatus.SERIAL_PORT_UNINITIALIZED;

            // Enabling Windows XP +visual effects before any controls are created
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SerialPortReadArray = new byte[33];
            SampleArray = new int[Constants.MAX_NUM_TESTS][];
            NumSamples = new int[Constants.MAX_NUM_TESTS];
            for (int i = 0; i < Constants.MAX_NUM_TESTS; i++)
                SampleArray[i] = new int[Constants.MAX_NUM_SAMPLES];
            NewLoadValues = new int[4];

            main_form = new Form1();

            MySerialObj = new KPSerialPort();

            //main_form = gcnew Form1();
            //newThread = gcnew System::Threading::Thread(gcnew ThreadStart(&mytemp));
            //formThread = gcnew System::Threading::Thread(gcnew ParameterizedThreadStart(main_form,&Form1::frmNewFormThread));
            System.Threading.Thread formThread = new System.Threading.Thread(new System.Threading.ThreadStart(newFormThread));


            formThread.SetApartmentState(System.Threading.ApartmentState.STA);
            formThread.Start();
            //formThread->Join();

            //let the form thread start.
            System.Threading.Thread.Sleep(3000);

            //wait while thread is started
            while (!formThread.IsAlive) { };


            if (SimulateSerialPort)
            {
                AveragingStarted = true;
                NumSamples[0] = 0;
                main_form.ClearChart(0);

            }

            while (true)
            {
                //if form thread is closed just exit
                if (!formThread.IsAlive)
                {
                    if (main_form.SerialPortValidated)
                    {
                        MySerialObj._serialPort.Close();
                        main_form.SerialPortValidated = false;
                    }
                    break;
                }

                if (main_form.SerialPortValidated)
                {
                    if (MySerialObj.GetSerialPortPacket(SerialPortReadArray, main_form.TestSelected))
                    {
                        if (main_form.TestSelected == 0)   //peel test
                        {
                            if ((SerialPortReadArray[5] == 0x0A) && (SerialPortReadArray[4] == 0x0D))
                            {
                                if ((SerialPortReadArray[0] == 'S') && (SerialPortReadArray[1] == 'T') && 
							        (SerialPortReadArray[2] == 'R') && (SerialPortReadArray[3] == 'T'))
						        {
                                    AveragingStarted = true;
                                    NumSamples[TestCount] = 0;
                                    main_form.ClearChart(TestCount);
                                }

						        else if ((SerialPortReadArray[0] == 'S') && (SerialPortReadArray[1] == 'T') && 
							        (SerialPortReadArray[2] == 'O') && (SerialPortReadArray[3] == 'P'))
						        {
                                    AveragingStarted = false;
                                    TestCount++;
                                    if (TestCount == Constants.MAX_NUM_TESTS)
                                        TestCount = 0;
                                }
						        else if (AveragingStarted)
                                {
                                    Val = (SerialPortReadArray[0] - '0') * 1000 + (SerialPortReadArray[1] - '0') * 100 + 
								        (SerialPortReadArray[2] - '0') * 10 + (SerialPortReadArray[3] - '0');
                                    main_form.UpdateChartPoint(TestCount, Val);
                                    if (NumSamples[TestCount] < Constants.MAX_NUM_SAMPLES)
                                        SampleArray[TestCount][NumSamples[TestCount]++] = Val;
                                }
                            }
                        }
                        else if (main_form.TestSelected == 1)
                        {

                            if ((SerialPortReadArray[0] == 'T') && (SerialPortReadArray[1] == '1') && (SerialPortReadArray[2] == '=') && (SerialPortReadArray[9] == 0x0D) && (SerialPortReadArray[10] == 0x0A)
                                && (SerialPortReadArray[11] == 'T') && (SerialPortReadArray[12] == '2') && (SerialPortReadArray[13] == '=') && (SerialPortReadArray[20] == 0x0D) && (SerialPortReadArray[21] == 0x0A)
                                && (SerialPortReadArray[22] == 'T') && (SerialPortReadArray[23] == '3') && (SerialPortReadArray[24] == '=') && (SerialPortReadArray[31] == 0x0D) && (SerialPortReadArray[32] == 0x0A))

                            {
                                Val = AsciiToInt(SerialPortReadArray, 3);
                                SampleArray[0][NumSamples[0]++] = Val;
                                main_form.UpdateChartPoint(0, Val);
                                Val = AsciiToInt(SerialPortReadArray, 14);
                                SampleArray[1][NumSamples[1]++] = Val;
                                main_form.UpdateChartPoint(1, Val);
                                Val = AsciiToInt(SerialPortReadArray, 25);
                                SampleArray[2][NumSamples[2]++] = Val;
                                main_form.UpdateChartPoint(2, Val);
                            }
                            else
                            {

                            }

                        }
                        else
                        {
                            status = (int) WirelessMonitorStatus.SERIAL_PORT_SYNC_LOST;
                            main_form.SerialPortValidated = false;
                            MySerialObj._serialPort.Close();

                        }
                    }
                    else
                    {
                        status = (int)WirelessMonitorStatus.SERIAL_PORT_READTIMEOUT;
                        main_form.SerialPortValidated = false;
                        MySerialObj._serialPort.Close();

                    }
                }
                else
                {
                    if (MySerialObj._serialPort != null)
                        MySerialObj._serialPort.Close();

                }

                if (formThread.IsAlive)
                    main_form.UpdateCommStatus(status);

                if (status!=0)
                    Thread.Sleep(500);



                if ((!main_form.SerialPortValidated) && formThread.IsAlive && (!SimulateSerialPort))
                {
                    if (MySerialObj._serialPort != null)
                        MySerialObj._serialPort.Close();
                    //Attempt to connect to serial port

                    main_form.GetSystemCommPortsAndInitCommMenu();
                    status = MySerialObj.InitSerialPort(main_form.SelectedCommPort, main_form.NumCommPorts, main_form.TestSelected);
                    if (status == (int)WirelessMonitorStatus.SERIAL_PORT_SUCCESS)
                        main_form.SerialPortValidated = true;
                    if (formThread.IsAlive)
                        main_form.UpdateCommStatus(status);
                    if (status != 0)
                        Thread.Sleep(500);
                }

                if (SimulateSerialPort && AveragingStarted)
                {
                    NewLoadValues[0] = 4 * Val + 0;
                    NewLoadValues[1] = 4 * Val + 1;
                    NewLoadValues[2] = 4 * Val + 2;
                    NewLoadValues[3] = 4 * Val + 3;

                    main_form.UpdateChartPoint(TestCount, NewLoadValues[0]);
                    main_form.UpdateChartPoint(TestCount, NewLoadValues[1]);
                    main_form.UpdateChartPoint(TestCount, NewLoadValues[2]);
                    main_form.UpdateChartPoint(TestCount, NewLoadValues[3]);
                    Val += 4;
                    NumSamples[TestCount] += 4;
                    if (Val >= 4 * 10)
                    {
                        TestCount++;
                        if (TestCount < 3)
                        {
                            NumSamples[TestCount] = 0;
                            main_form.ClearChart(TestCount);
                            Val = 0;
                        }
                        else
                            AveragingStarted = false;

                    }

                    Thread.Sleep(1000);
                }



            }
        }
    }
}
