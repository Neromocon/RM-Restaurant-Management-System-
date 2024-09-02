using _RM.Model;
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

namespace _RM.View
{
    public partial class frmTableView : SampleView
    {
        public frmTableView()
        {
            InitializeComponent();
        }
        private void frmTableView_Load(object sender, EventArgs e)
        {
            // 테이블 데이터베이스 먼저 만들기
            GetData();
        }

        public void GetData()
        {
            string qry = "Select * From tables where tName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            // 블루 이펙트 추가
            //frmTableAdd frm = new frmTableAdd();
            //frm.ShowDialog();

            MainClass.BlueBackground(new Model.frmTableAdd());


            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // 데이터베이스에서 데이터테이블을 먼저 만들어야함.
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {


                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("정말 삭제하시겠습니까?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string gry = "Delete from tables where tID= " + id + " ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(gry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("삭제가 완료되었습니다.");
                    GetData();
                }

            }
        }

    }
}
