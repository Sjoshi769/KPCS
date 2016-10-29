

using System;
using System.IO.Ports;
using System.Threading;


namespace KatpotCS
{




    abstract class KPSerialPort
    {

#if EMULATE_SERIAL_PORT
        private static int count = 0;
        //random_device rd();
        //mt19937 gen(rd());
        private static int l = 0;
#endif

        public int InitSerialPort(SerialPort _serialPort, String PortName, int NumPorts, int TestSelected)
        {

#if EMULATE_SERIAL_PORT
            return (int)WirelessMonitorStatus.SERIAL_PORT_SUCCESS;
#endif

            byte[] cTemp;
            int iTemp;

            bool Synced;

            if (NumPorts == 0)
            {
                return (int)WirelessMonitorStatus.SERIAL_PORT_NOT_DETECTED;
            }

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = PortName;
            _serialPort.BaudRate = Constants.SERIAL_PORT_BAUDRATE_VAL;
            _serialPort.Parity = System.IO.Ports.Parity.None;
            _serialPort.DataBits = Constants.SERIAL_PORT_DATA_BITS_VAL;
            _serialPort.StopBits = System.IO.Ports.StopBits.One;
            _serialPort.Handshake = System.IO.Ports.Handshake.None;
            _serialPort.ReadTimeout = Constants.SERIAL_PORT_READ_TIMEOUT_VAL;
            _serialPort.WriteTimeout = Constants.SERIAL_PORT_WRITE_TIMEOUT_VAL;

            cTemp = new byte[6];
            cTemp[0] = (byte)'E';
            cTemp[1] = (byte)'S';
            cTemp[2] = (byte)'C';
            cTemp[3] = (byte)'W';
            cTemp[4] = (byte)'M';
            cTemp[5] = 0;


            try {
                _serialPort.Open();
            }
            catch (ArgumentException) {
                //delete cTemp;
                return (int)WirelessMonitorStatus.SERIAL_PORT_INVALID_NAME_ERROR;
            }

            catch (UnauthorizedAccessException) {
                //delete cTemp;
                return (int)WirelessMonitorStatus.SERIAL_PORT_AUTHORIZATION_ERROR;
            }

            //No need for ArgumentOutOfRangeException.
            //This is same as ArgumentException
            //catch (ArgumentOutOfRangeException ^) {
            //	delete cTemp;
            //	return SERIAL_PORT_ARGUMENT_ERROR;
            //}

            catch (System.IO.IOException) {
                //delete cTemp;
                return (int)WirelessMonitorStatus.SERIAL_PORT_IO_ERROR;
            }
            catch (InvalidOperationException) {
                //delete cTemp;
                return (int)WirelessMonitorStatus.SERIAL_PORT_ALREADY_OPEN_ERROR;
            }


            //_serialPort->DiscardInBuffer();
            //_serialPort->DiscardOutBuffer();


            //send a secret message to the device and wait for the proper response.
            // _serialPort->ReadTimeout	= SERIAL_PORT_READ_TIMEOUT_SYNC_VAL;


            //try {
            //	_serialPort->Write(cTemp,0,6);
            //}
            //catch (TimeoutException^ ex) {
            //	delete cTemp;
            //	_serialPort->Close();
            //	return SERIAL_PORT_WRITE_TIMEOUT;
            //}

            //now read back the response

            Synced = false;
            iTemp = 0;


            while (!Synced)
            {

                try {
                    cTemp[0] = (byte)_serialPort.ReadByte();
                }
                catch (TimeoutException ) {
                    //delete cTemp;
                    _serialPort.Close();
                    return (int)WirelessMonitorStatus.SERIAL_PORT_READTIMEOUT;
                }
                if (TestSelected == 1) //peel test
                {
                    if ((cTemp[1] == (byte)0x0D) && (cTemp[0] == 0x0A) && (iTemp > 6))
                    {
                        Synced = true;
                        break;
                    } else {
                        //shift delay line
                        cTemp[1] = cTemp[0];
                        cTemp[2] = cTemp[1];
                        cTemp[3] = cTemp[2];
                        cTemp[4] = cTemp[3];
                        cTemp[5] = cTemp[4];
                    }

                    iTemp++;
                    if (iTemp >= Constants.MAX_SYNC_BYTES)
                        break;
                }

                else {
                    //shear test
                    if ((cTemp[2] == 'T') && (cTemp[1] == '1') && (cTemp[0] == '='))
                    {
                        int i;
                        Synced = true;
                        //skipnext 8 + 11 + 11 bytes
                        for (i = 0; i < 8 + 11 + 11; i++)
                        {
                            try {
                                cTemp[0] = (byte)_serialPort.ReadByte();
                            }
                            catch (TimeoutException ) {
                                Synced = false;
                                break;
                            }
                        }
                        break;
                    } else {
                        //shift delay line
                        cTemp[1] = cTemp[0];
                        cTemp[2] = cTemp[1];
                        cTemp[3] = cTemp[2];
                        cTemp[4] = cTemp[3];
                        cTemp[5] = cTemp[4];
                    }

                    iTemp++;
                    if (iTemp >= Constants.MAX_SYNC_BYTES)
                        break;
                }
            }


            //delete cTemp;
            if (Synced)
                return (int)WirelessMonitorStatus.SERIAL_PORT_SUCCESS;
            else {
                _serialPort.Close();
                return (int)WirelessMonitorStatus.SERIAL_PORT_INVALID_RESPONSE;
            }
        }

        public bool GetSerialPortPacket(SerialPort _serialPort, byte[] readArray, int TestSelected)
        {
#if EMULATE_SERIAL_PORT
	        if (count==100)
	        {
		        readArray[0] = (byte) 'S';
		        readArray[1] = (byte)'T';
		        readArray[2] = (byte)'R';
		        readArray[3] = (byte)'T';
		        readArray[4] = (byte)'\r';
		        readArray[5] = (byte)'\n';
	        }
	        else if (count==200)
	        {
		        readArray[0] = (byte) 'S';
		        readArray[1] = (byte) 'T';
		        readArray[2] = (byte) 'O';
		        readArray[3] = (byte) 'P';
		        readArray[4] = (byte) '\r';
		        readArray[5] = (byte) '\n';
		        count = 0;
	        }
	        else
	        {
		        int k = l;
		        if (k < 0) k = -k;
		        k = k % 10000;
		        readArray[0] = (byte) ('0' + (k/1000));
		        k = k % 1000;
		        readArray[1] = (byte) ('0' + (k/100));
		        k = k % 100;
		        readArray[2] = (byte) ('0' + (k/10));
		        k = k % 10;
		        readArray[3] = (byte) ('0' + k);
		        readArray[4] = (byte) ('\r');
		        readArray[5] = (byte) '\n';
	        }
	        count++;
	        l++;
	        Thread.Sleep(100);
	        return true;
#else

            int BytesRead = 0;
            int BytesToRead;

            if (TestSelected != 0)
                BytesToRead = 11 * 3;
            else
                BytesToRead = Constants.SERIAL_PORT_PACKET_SIZE;



            while (BytesRead < BytesToRead)
            {
                try {
                    BytesRead += _serialPort.Read(readArray, BytesRead, BytesToRead - BytesRead);
                }
                catch (TimeoutException ) {
                    return false;
                }
            }


            return true;
#endif

        }
    }
}






	