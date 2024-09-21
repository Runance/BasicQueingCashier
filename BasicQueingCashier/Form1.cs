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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
       
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm queueForm = new CashierWindowQueueForm();
            queueForm.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
          
            CashierClass.getNumberInQueue = lblQueue.Text;

            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
