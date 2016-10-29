using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace KatpotCS
{

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
                    formThread.Abort();
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
