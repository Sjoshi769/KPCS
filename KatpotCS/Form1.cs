﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
//using DevExpress.Xpf.Charts;

namespace KatpotCS
{
    public partial class Form1 : Form
    {
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            // Declares the Graphics object and sets it to the Graphics object
            // supplied in the PaintEventArgs.
            Graphics g = pe.Graphics;
            // Insert code to paint the form here.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            // Call methods of the System.Drawing.Graphics object.
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            // Create location and size of rectangle.
            int x = 110;
            int y = 110;
            int width = 200;
            int height = 200;
            Rectangle rect = new Rectangle(x, y, width, height);
            // Draw rectangle to screen.
            //formGraphics.DrawRectangle(blackPen, rect);
            
            // Call the OnPaint method of the base class.
            //base.OnPaint(e);
            //rect.v


            // Declare and instantiate a new pen.
            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Aqua);

            // Draw an aqua rectangle in the rectangle represented by the control.
            e.Graphics.DrawRectangle(myPen, rect);
            //blackPen.Dispose();
            //formGraphics.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            //this.control.Add()
        }

        delegate void ClearChartDelegate(int index);

       
	    public void ClearChart(int index)
        {
            if (this.chart1.InvokeRequired)
            {
                ClearChartDelegate  d =
                    new ClearChartDelegate(ClearChart);
                this.Invoke(d, index);

            }
            else
            {
                //this.series1[index]->Points->Clear();
            }
        }

        delegate void UpdateCommStatusDelegate(int status);

  
	    public void UpdateCommStatus(int status)
        {
            String DisplayMessageString = "";


            if (this.label1.InvokeRequired)
            {

                UpdateCommStatusDelegate  d =
                    new UpdateCommStatusDelegate(UpdateCommStatus);
                this.Invoke(d, status);
            }
            else
            {

                switch (status)
                {

                    case (int) WirelessMonitorStatus.SERIAL_PORT_SUCCESS:
                        {
                            //this->label43->Text =  ;
                            DisplayMessageString =  "Connected To Comm Port " + SelectedCommPort + " .";
                            break;
                        }


                    case (int) WirelessMonitorStatus.SERIAL_PORT_UNINITIALIZED:
                        {
                            //this->label43->Text =  ;
                            DisplayMessageString = "Serial Port is Not Initialized" ;
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_WRITE_TIMEOUT:
                        {
                            DisplayMessageString = "Write To Comm Port " + SelectedCommPort + " Timed Out.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_READTIMEOUT:
                        {
                            DisplayMessageString = "Read From Comm Port " + SelectedCommPort + " Timed Out.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_INVALID_RESPONSE:
                        {
                            DisplayMessageString = "Device Connected To Comm Port " + SelectedCommPort + " Is Not WirelessMonitor Receiver.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_NOT_DETECTED:
                        {
                            DisplayMessageString = "No valid Comm Port Detected. Please Check The Connection.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_AUTHORIZATION_ERROR:
                        {
                            DisplayMessageString = "Access To Comm Port " + SelectedCommPort + " Denied.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_INVALID_NAME_ERROR:
                        {
                            DisplayMessageString = "Port Name " + SelectedCommPort + " Is Invalid.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_ARGUMENT_ERROR:
                        {
                            DisplayMessageString = "Invalid Configuration Parameters Specified.";
                            break;
                        }
                    case (int)WirelessMonitorStatus.SERIAL_PORT_IO_ERROR:

                        {
                            DisplayMessageString = "Comm Port " + SelectedCommPort + " Is In Invalid State.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_ALREADY_OPEN_ERROR:
                        {
                            DisplayMessageString = "Comm Port " + SelectedCommPort + " Is Already In Use.";
                            break;
                        }

                    case (int)WirelessMonitorStatus.SERIAL_PORT_SYNC_LOST:
                        {
                            DisplayMessageString = "Serial Port Synchronization Lost. Re-attempting";
                            break;
                        }

                }
                this.label1.Text = DisplayMessageString;   
            }
        }


        delegate void GetSystemCommPortsAndInitCommMenuDelegate();


        public void GetSystemCommPortsAndInitCommMenu()
        {

            if (this.InvokeRequired)
            {
                GetSystemCommPortsAndInitCommMenuDelegate d =
                    new GetSystemCommPortsAndInitCommMenuDelegate(GetSystemCommPortsAndInitCommMenu);
                this.Invoke(d);
                return;
            }
            else
            {
                int temp;

                try
                {
                    if (this.SystemserialPorts != null)
                        this.SystemserialPorts = null;
                    // Get a list of serial port names.
                    SystemserialPorts = SerialPort.GetPortNames();
                }
                catch (Win32Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                NumCommPorts = 0;

                // Display each port name to the console. 
                foreach (String port in SystemserialPorts)

                {
                    //Console::WriteLine(port);
                    NumCommPorts++;
                }


                if (NumCommPorts > Constants.MAX_COMM_PORTS_IN_SYSTEM)
                    NumCommPorts = Constants.MAX_COMM_PORTS_IN_SYSTEM;

                if (COMToolStripMenuItemRuntimeArray != null)
                    COMToolStripMenuItemRuntimeArray = null;

                //if (this->toolStripMenuItem2->DropDownItems)
                //	delete (this->toolStripMenuItem2->DropDownItems);

                COMToolStripMenuItemRuntimeArray = new System.Windows.Forms.ToolStripMenuItem[NumCommPorts];

                for (temp = 0; temp < NumCommPorts; temp++)
                {

                    this.COMToolStripMenuItemRuntimeArray[temp].Name = "cOM" + temp.ToString() + "ToolStripMenuItem";
                    this.COMToolStripMenuItemRuntimeArray[temp].Size = new System.Drawing.Size(114, 22);
                    this.COMToolStripMenuItemRuntimeArray[temp].Text = SystemserialPorts[temp];
                    this.COMToolStripMenuItemRuntimeArray[temp].Click += new System.EventHandler(cOMToolStripMenuItem_Click);

                }

            }
        }

        delegate void UpdateChartPointDelegate(int SeriesIndex, int Val);

	    public void UpdateChartPoint(int SeriesIndex, int Val)
        {
            if (this.chart1.InvokeRequired)
            {
                UpdateChartPointDelegate d =
                    new UpdateChartPointDelegate(UpdateChartPoint);
                this.Invoke(d, SeriesIndex, Val);
                return;
            }
            else
            {
                this.series1[SeriesIndex].Points.AddY(Val);
            }
        }


        private void fileMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "png files (*.png)|*.png|xls files (*.xls)|*.xls";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var extension = Path.GetExtension(saveFileDialog1.FileName);

                    switch (extension.ToLower())
                    {
                        case ".png":
                            // Save as JPEG
                            this.chart1.SaveImage(myStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                            break;
                        case ".cls":
                            // Save as XLS
                            //MyXLStest(saveFileDialog1->FileName, this->TestSelected);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(extension);
                    }
                    myStream.Close();
                }
            }
        }

        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //turn on Grid
            this.chartArea1.AxisX.MajorGrid.LineWidth = 1;
            this.chartArea1.AxisY.MajorGrid.LineWidth = 1;
            this.gridOffToolStripMenuItem.Checked = false;
            this.gridOnToolStripMenuItem.Checked = true;
        }
        private void gridOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //turn on Grid
            this.chartArea1.AxisX.MajorGrid.LineWidth = 0;
            this.chartArea1.AxisY.MajorGrid.LineWidth = 0;
            this.gridOffToolStripMenuItem.Checked = true;
            this.gridOnToolStripMenuItem.Checked = false;
        }

        private void MouseEvents(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //blah blah
            }
        }
        private void autoCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shearTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peelTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void degreeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void degreeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void itemNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manufacturingDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really want to  quit ?", " ", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.UserExitRequested = true;
                Application.Exit();
            }
        }

        private void cOMToolStripMenuItem_Click(object  sender, EventArgs  e)
        {
            SelectedCommPort = ((System.Windows.Forms.ToolStripMenuItem)sender).Text;
            SerialPortValidated = false;
        }
        

        private void returnToProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
