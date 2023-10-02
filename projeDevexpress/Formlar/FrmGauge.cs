using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeDevexpress.Formlar
{
    public partial class FrmGauge : Form
    {
        public FrmGauge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent2.Value += 5;
            arcScaleComponent5.Value += 5;
            labelComponent1.Text = arcScaleComponent5.Value.ToString();
            if (arcScaleComponent2.Value == 180)
            {
                timer1.Stop();
                timer2.Start();
                    }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent5.Value -= 5;
            labelComponent1.Text = arcScaleComponent5.Value.ToString();
            arcScaleComponent2.Value -= 5;
            if (arcScaleComponent2.Value == 0)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

    }
}
