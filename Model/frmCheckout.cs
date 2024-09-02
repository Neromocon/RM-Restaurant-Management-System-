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

namespace _RM.Model
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        public double amt;
        public int MainID = 0;

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);
            
            change = Math.Abs(amt - receipt); 
            // 항상 양수로 표기할 수 있게 Math.Abs()를 사용함.

            txtChange.Text = change.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = @"Update tblMain set total = @total, received = @received, change = @change,
                                status = '지불 완료' where MainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@received", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("계산이 완료 되었습니다!");
                this.Close();
            }


        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amt.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
