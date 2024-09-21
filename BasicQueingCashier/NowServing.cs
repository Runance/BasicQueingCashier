using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueingCashier
{
    public partial class NowServing : Form
    {
       
        public NowServing()
        {
            InitializeComponent();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                 label2.Text = CashierClass.CashierQueue.Peek();
            }
        }
    }
}