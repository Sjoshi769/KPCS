using System.Drawing;
using System.Windows.Forms;


namespace KatpotCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peelTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.itemNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.drawingNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.manufacturingDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.inspectionDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.batchNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.materialTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox8 = new System.Windows.Forms.ToolStripTextBox();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox9 = new System.Windows.Forms.ToolStripTextBox();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox10 = new System.Windows.Forms.ToolStripTextBox();
            this.weightAppliedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox11 = new System.Windows.Forms.ToolStripTextBox();
            this.minimumLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox12 = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuToolStripMenuItem,
            this.cOMPortToolStripMenuItem,
            this.gridOptionsToolStripMenuItem,
            this.captureOptionsToolStripMenuItem,
            this.testTypeToolStripMenuItem,
            this.testDegreeToolStripMenuItem,
            this.testSetupToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuToolStripMenuItem
            // 
            this.fileMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.saveFileToolStripMenuItem});
            this.fileMenuToolStripMenuItem.Name = "fileMenuToolStripMenuItem";
            this.fileMenuToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fileMenuToolStripMenuItem.Text = "File Options";
            this.fileMenuToolStripMenuItem.Click += new System.EventHandler(this.fileMenuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem1.Text = "Load File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            this.cOMPortToolStripMenuItem.Click += new System.EventHandler(this.cOMPortToolStripMenuItem_Click);
            // 
            // gridOptionsToolStripMenuItem
            // 
            this.gridOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridOnToolStripMenuItem,
            this.gridOffToolStripMenuItem});
            this.gridOptionsToolStripMenuItem.Name = "gridOptionsToolStripMenuItem";
            this.gridOptionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.gridOptionsToolStripMenuItem.Text = "Grid Options";
            this.gridOptionsToolStripMenuItem.Click += new System.EventHandler(this.gridOptionsToolStripMenuItem_Click);
            // 
            // gridOnToolStripMenuItem
            // 
            this.gridOnToolStripMenuItem.Name = "gridOnToolStripMenuItem";
            this.gridOnToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gridOnToolStripMenuItem.Text = "Grid On";
            this.gridOnToolStripMenuItem.Click += new System.EventHandler(this.gridOnToolStripMenuItem_Click);
            // 
            // gridOffToolStripMenuItem
            // 
            this.gridOffToolStripMenuItem.Name = "gridOffToolStripMenuItem";
            this.gridOffToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gridOffToolStripMenuItem.Text = "Grid Off";
            this.gridOffToolStripMenuItem.Click += new System.EventHandler(this.gridOffToolStripMenuItem_Click);
            // 
            // captureOptionsToolStripMenuItem
            // 
            this.captureOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoCaptureToolStripMenuItem,
            this.manualCaptureToolStripMenuItem});
            this.captureOptionsToolStripMenuItem.Name = "captureOptionsToolStripMenuItem";
            this.captureOptionsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.captureOptionsToolStripMenuItem.Text = "Capture Options";
            // 
            // autoCaptureToolStripMenuItem
            // 
            this.autoCaptureToolStripMenuItem.Name = "autoCaptureToolStripMenuItem";
            this.autoCaptureToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.autoCaptureToolStripMenuItem.Text = "Auto Capture";
            this.autoCaptureToolStripMenuItem.Click += new System.EventHandler(this.autoCaptureToolStripMenuItem_Click);
            // 
            // manualCaptureToolStripMenuItem
            // 
            this.manualCaptureToolStripMenuItem.Name = "manualCaptureToolStripMenuItem";
            this.manualCaptureToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manualCaptureToolStripMenuItem.Text = "Manual Capture";
            this.manualCaptureToolStripMenuItem.Click += new System.EventHandler(this.manualCaptureToolStripMenuItem_Click);
            // 
            // testTypeToolStripMenuItem
            // 
            this.testTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shearTestToolStripMenuItem,
            this.peelTestToolStripMenuItem});
            this.testTypeToolStripMenuItem.Name = "testTypeToolStripMenuItem";
            this.testTypeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.testTypeToolStripMenuItem.Text = "Test Type";
            // 
            // shearTestToolStripMenuItem
            // 
            this.shearTestToolStripMenuItem.Name = "shearTestToolStripMenuItem";
            this.shearTestToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.shearTestToolStripMenuItem.Text = "Shear Test";
            this.shearTestToolStripMenuItem.Click += new System.EventHandler(this.shearTestToolStripMenuItem_Click);
            // 
            // peelTestToolStripMenuItem
            // 
            this.peelTestToolStripMenuItem.Name = "peelTestToolStripMenuItem";
            this.peelTestToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.peelTestToolStripMenuItem.Text = "Peel Test";
            this.peelTestToolStripMenuItem.Click += new System.EventHandler(this.peelTestToolStripMenuItem_Click);
            // 
            // testDegreeToolStripMenuItem
            // 
            this.testDegreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.degreeToolStripMenuItem,
            this.degreeToolStripMenuItem1});
            this.testDegreeToolStripMenuItem.Name = "testDegreeToolStripMenuItem";
            this.testDegreeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.testDegreeToolStripMenuItem.Text = "Test Degree";
            // 
            // degreeToolStripMenuItem
            // 
            this.degreeToolStripMenuItem.Name = "degreeToolStripMenuItem";
            this.degreeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.degreeToolStripMenuItem.Text = "90 Degree";
            this.degreeToolStripMenuItem.Click += new System.EventHandler(this.degreeToolStripMenuItem_Click);
            // 
            // degreeToolStripMenuItem1
            // 
            this.degreeToolStripMenuItem1.Name = "degreeToolStripMenuItem1";
            this.degreeToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.degreeToolStripMenuItem1.Text = "180 Degree";
            this.degreeToolStripMenuItem1.Click += new System.EventHandler(this.degreeToolStripMenuItem1_Click);
            // 
            // testSetupToolStripMenuItem
            // 
            this.testSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerNameToolStripMenuItem,
            this.iToolStripMenuItem,
            this.itemNumberToolStripMenuItem,
            this.drawingNumberToolStripMenuItem,
            this.manufacturingDateToolStripMenuItem,
            this.inspectionDateToolStripMenuItem,
            this.batchNoToolStripMenuItem,
            this.materialTypeToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.weightAppliedToolStripMenuItem,
            this.minimumLengthToolStripMenuItem});
            this.testSetupToolStripMenuItem.Name = "testSetupToolStripMenuItem";
            this.testSetupToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.testSetupToolStripMenuItem.Text = "Test Setup";
            // 
            // customerNameToolStripMenuItem
            // 
            this.customerNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.customerNameToolStripMenuItem.Name = "customerNameToolStripMenuItem";
            this.customerNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerNameToolStripMenuItem.Text = "Customer Name";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iToolStripMenuItem.Text = "Item Name";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // itemNumberToolStripMenuItem
            // 
            this.itemNumberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.itemNumberToolStripMenuItem.Name = "itemNumberToolStripMenuItem";
            this.itemNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemNumberToolStripMenuItem.Text = "Item Number";
            this.itemNumberToolStripMenuItem.Click += new System.EventHandler(this.itemNumberToolStripMenuItem_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // drawingNumberToolStripMenuItem
            // 
            this.drawingNumberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4});
            this.drawingNumberToolStripMenuItem.Name = "drawingNumberToolStripMenuItem";
            this.drawingNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawingNumberToolStripMenuItem.Text = "Drawing Number";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            // 
            // manufacturingDateToolStripMenuItem
            // 
            this.manufacturingDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox5});
            this.manufacturingDateToolStripMenuItem.Name = "manufacturingDateToolStripMenuItem";
            this.manufacturingDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manufacturingDateToolStripMenuItem.Text = "Manufacturing Date";
            this.manufacturingDateToolStripMenuItem.Click += new System.EventHandler(this.manufacturingDateToolStripMenuItem_Click);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            // 
            // inspectionDateToolStripMenuItem
            // 
            this.inspectionDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox6});
            this.inspectionDateToolStripMenuItem.Name = "inspectionDateToolStripMenuItem";
            this.inspectionDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inspectionDateToolStripMenuItem.Text = "Inspection Date";
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 23);
            // 
            // batchNoToolStripMenuItem
            // 
            this.batchNoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox7});
            this.batchNoToolStripMenuItem.Name = "batchNoToolStripMenuItem";
            this.batchNoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batchNoToolStripMenuItem.Text = "Batch No.";
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(100, 23);
            // 
            // materialTypeToolStripMenuItem
            // 
            this.materialTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox8});
            this.materialTypeToolStripMenuItem.Name = "materialTypeToolStripMenuItem";
            this.materialTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialTypeToolStripMenuItem.Text = "Material Type";
            // 
            // toolStripTextBox8
            // 
            this.toolStripTextBox8.Name = "toolStripTextBox8";
            this.toolStripTextBox8.Size = new System.Drawing.Size(100, 23);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox9});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // toolStripTextBox9
            // 
            this.toolStripTextBox9.Name = "toolStripTextBox9";
            this.toolStripTextBox9.Size = new System.Drawing.Size(100, 23);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox10});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // toolStripTextBox10
            // 
            this.toolStripTextBox10.Name = "toolStripTextBox10";
            this.toolStripTextBox10.Size = new System.Drawing.Size(100, 23);
            // 
            // weightAppliedToolStripMenuItem
            // 
            this.weightAppliedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox11});
            this.weightAppliedToolStripMenuItem.Name = "weightAppliedToolStripMenuItem";
            this.weightAppliedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weightAppliedToolStripMenuItem.Text = "Weight Applied";
            // 
            // toolStripTextBox11
            // 
            this.toolStripTextBox11.Name = "toolStripTextBox11";
            this.toolStripTextBox11.Size = new System.Drawing.Size(100, 23);
            // 
            // minimumLengthToolStripMenuItem
            // 
            this.minimumLengthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox12});
            this.minimumLengthToolStripMenuItem.Name = "minimumLengthToolStripMenuItem";
            this.minimumLengthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimumLengthToolStripMenuItem.Text = "Minimum Length";
            // 
            // toolStripTextBox12
            // 
            this.toolStripTextBox12.Name = "toolStripTextBox12";
            this.toolStripTextBox12.Size = new System.Drawing.Size(100, 23);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitProgramToolStripMenuItem,
            this.returnToProgramToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // returnToProgramToolStripMenuItem
            // 
            this.returnToProgramToolStripMenuItem.Name = "returnToProgramToolStripMenuItem";
            this.returnToProgramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.returnToProgramToolStripMenuItem.Text = "Return To Program";
            this.returnToProgramToolStripMenuItem.Click += new System.EventHandler(this.returnToProgramToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";

            UserExitRequested = false;
            SerialPortValidated = false;
#if ENABLE_DESIGNER
            //
            //legend1
            //
            this.legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            //

            // 
            // chart1
            // 
            this.chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(this.chartArea1);
            this.legend1.Name = "Legend1";
            this.chart1.Legends.Add(this.legend1);
            this.chart1.Location = new Point(12, 42);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;


            //enable zoom
            this.chartArea1.AxisX.ScaleView.Zoomable = true;
            this.chartArea1.AxisY.ScaleView.Zoomable = false;

            this.chartArea1.CursorX.IsUserSelectionEnabled = true;
            this.chartArea1.CursorY.IsUserSelectionEnabled = false;

            this.chartArea1.CursorX.AutoScroll = true;
            this.chartArea1.CursorY.AutoScroll = false;



            //
            //series[]
            //
            series1 = new System.Windows.Forms.DataVisualization.Charting.Series[Constants.MAX_NUM_TESTS];

            for (int i = 0; i < Constants.MAX_NUM_TESTS; i++)
            {
                //
                // series[]
                //
                this.series1[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                this.series1[i].ChartArea = "ChartArea1";
                this.series1[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                this.series1[i].Legend = "Legend1";
                this.series1[i].Name = "Sample  Vs Load Test-" + (i + 1).ToString();
                this.chart1.Series.Add(this.series1[i]);
                this.chart1.Size = new Size(984, 300);
                this.chart1.TabIndex = 1;
                this.chart1.Text = "chart1";
            }
#endif

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "                                                                            " ;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 355);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 2;
            label2.Text = "Comm Port Status";

            //
            //mouse event handler
            //
            //this.MouseWheel += new System.Windows.Forms.MouseEventHandler(MouseEvents);
            //


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCaptureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualCaptureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peelTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturingDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspectionDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightAppliedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox9;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox11;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox12;

        public bool UserExitRequested;
        public bool SerialPortValidated;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Series[] series1;
        private System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1;
        private System.Windows.Forms.DataVisualization.Charting.Legend legend1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public string SelectedCommPort = null; 
        private string[] SystemserialPorts = null;
        public int NumCommPorts = 0;
        public int TestSelected = 0;
        private System.Windows.Forms.ToolStripMenuItem[] COMToolStripMenuItemRuntimeArray;

    }
}

