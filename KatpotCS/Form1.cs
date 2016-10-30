using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KatpotCS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
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


        private void fileMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grdiOffToolStripMenuItem_Click(object sender, EventArgs e)
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

        }

        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridOnToolStripMenuItem_Click(object sender, EventArgs e)
        {

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


        private void returnToProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
