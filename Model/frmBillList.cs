using _RM.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _RM.Model
{
    public partial class frmBillList : Form
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"select MainID, TableName, WaiterName, orderType, status, total from tblMain
                                   where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 시리얼 넘버
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                // 열기 전에 양식 텍스트 옵션을 설정해야 하기 때문에 변경함.
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
                
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // 영수증 출력하기
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"Select * from tblMain m inner join
                                tblDetails d on d.MainID = m.MainID
                                inner join products p on p.PID = d.ProID
                                where m.MainID = "+ MainID + " ";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                frmPrint frm = new frmPrint();
                rptBill cr = new rptBill();

                cr.SetDatabaseLogon("sa", "123");
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();

            }

        }


    }
}
