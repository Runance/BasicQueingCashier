using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        Timer timer;
        NowServing serving = new NowServing();
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer1_Tick); 
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string nextCustomer = CashierClass.CashierQueue.Dequeue();
            
                serving.label2.Text = nextCustomer;
            
                serving.Show();
            }
            else
            {
                MessageBox.Show("No Available Queues");
               
                serving.label2.Text = ("--------");
            }
            DisplayCashierQueue(CashierClass.CashierQueue); 
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
    }
}
