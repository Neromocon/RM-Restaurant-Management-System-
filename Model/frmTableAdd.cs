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
    public partial class frmTableAdd : Form
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tables Values(@Name)";
            }
            else
            {
                qry = "Update tables Set tName = @Name where tID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("성공적으로 저장되었습니다!");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
