using Guna.UI2.WinForms;
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
using System.Windows.Forms.Design;

namespace _RM.Model
{
    public partial class frmCategoryAdd : Form
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public  void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public  void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if(id == 0)
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if(MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("성공적으로 저장되었습니다!");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

    }





    


}
