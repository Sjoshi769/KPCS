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

    }

    static class Program
    {

        static Form1 main_form;
        static SerialPort _serialPort;

        static void newFormThread()
        {
           
            Application.Run(main_form);
        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // Enabling Windows XP +visual effects before any controls are created
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            main_form = new Form1();

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

            while (true)
            {

                //check if user wants to close it
                if (main_form.UserExitRequested == true)
                {
                    //MyXLStest("Trial1");
                    try
                    {
                        formThread.Abort();
                    }
                    catch (ThreadAbortException)
                    {
                        //for now do nothing
                    }
                    formThread.Join();
                }

                //if form thread is closed just exit
                if (!formThread.IsAlive)
                {
                    if (main_form.SerialPortValidated)
                    {
                        _serialPort.Close();
                        main_form.SerialPortValidated = false;
                    }
                    break;
                }

            }
        }
    }
}
