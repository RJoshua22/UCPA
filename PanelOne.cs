using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCP_Activity
{
    public partial class PanelOne : UserControl
    {
        public PanelOne()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var p1in1 = this.p1in1.Text;
            var p1in2 = this.p1in2.Text;

            //Parent
            var parent = this.Parent as Form1;
            parent.OneInput = p1in1;
            parent.TwoInput = p1in2;
        }
    }
}