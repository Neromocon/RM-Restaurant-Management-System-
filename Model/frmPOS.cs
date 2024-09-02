using Guna.UI2.Designer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _RM.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType = "";
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
            //GetTotal();
        }

        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(65, 105, 225);
                    b.Size = new Size(170, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    // 클릭 이벤트
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }
                
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if (b.Text == "전 체")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // 물품확인하기, 물품 등록...
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        //GetTotal();
                        return;
                    }
                   
                }
                // 새 물품 추가하기.
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };

        }

        // 물품을 데이터베이스에서 가져오기

        private void LoadProducts()
        {
            string qry = "Select * from products inner join category on catID = CategoryID ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearry = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item; 
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
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

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = $"{(int)tot}";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblDriverName.Text = "";
            lblWaiter.Text = "";
            lblDriverName.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblDriverName.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblDriverName.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "배달";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlueBackground(frm);

            if (frm.txtName.Text != "") // 테이크아웃에는 운전자가 없었기 때문에 추가함.
            {
                driverID = frm.driverID;
                lblDriverName.Text = "고객 이름: " + frm.txtName.Text + " 연락처: " + frm.txtPhone.Text + "담당 배달부: " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblDriverName.Text = "";
            lblWaiter.Text = "";
            lblDriverName.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "포장";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlueBackground(frm);

            if (frm.txtName.Text != "") // 테이크아웃에는 운전자가 없었기 때문에 추가함.
            {
                driverID = frm.driverID;
                lblDriverName.Text = "고객 이름: " + frm.txtName.Text + " 연락처: " + frm.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "매 장";
            lblDriverName.Visible = false ;
            // 테이블과 웨이터 선택이 필요함
            frmTableSelect frm = new frmTableSelect();
            MainClass.BlueBackground(frm);
            if (frm.TableName != "")
            {
                lblDriverName.Text = frm.TableName;
                lblDriverName.Visible = true;
            }
            else
            {
                lblDriverName.Text = "";
                lblDriverName.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlueBackground(frm2);
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }


        }

        private void btnKot_Click(object sender, EventArgs e)
        {

            // 데이터 베이스에 데이터 저장.
            // 데이터 테이블 생성.
            // 추가 정보를 저장하려면 데이터테이블에 새쿼리를 추가해야 합니다

            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            int detailID = 0;


            if (MainID == 0)  // Insert
            {
                qry1 = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName,  
                            @status, @orderType, @total, @received, @change, @driverID, @CusName, @CusPhone);
                                    Select SCOPE_IDENTITY()";

                // 이 행은 최근 추가 값을 가져옴.
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total,  
                                        received = @received, change = @change where MainID = @ID";
            }            
            
            
            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblDriverName.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "대 기");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); // 주방에 대한 데이터만 저장하면 결제가 들어오면 업데이트됨
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CusName", customerName);
            cmd.Parameters.AddWithValue("@CusPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed){ MainClass.con.Open();}
            if (MainID == 0){ MainID = Convert.ToInt32(cmd.ExecuteScalar());} else {cmd.ExecuteNonQuery();}
            if (MainClass.con.State == ConnectionState.Open){ MainClass.con.Close();}

            foreach( DataGridViewRow row in guna2DataGridView1.Rows )
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // 입력
                {
                    qry2 = @"Insert into tblDetails Values( @MainID, @proID, @qty, @price, @amount )";
                }
                else  // 수정
                {
                    qry2 = @" Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetaildID = @ID ";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }                             
                cmd2.ExecuteNonQuery();                
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                //guna2MessageDialog1.Show("성공적으로 저장 되었습니다!");
                //MainID = 0;
                //detailID = 0;
                //guna2DataGridView1.Rows.Clear();

                //lblDriverName.Text = "";
                //lblWaiter.Text = "";
                //lblDriverName.Visible = false;
                //lblWaiter.Visible = false;
                //lblDriverName.Text = "00";
                //lblDriverName.Text = "";

            }

            guna2MessageDialog1.Show("성공적으로 저장 되었습니다!");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();

            lblDriverName.Text = "";
            lblWaiter.Text = "";
            lblDriverName.Visible = false;
            lblWaiter.Visible = false;
            lblDriverName.Text = "00";
            lblDriverName.Text = "";

        }

        public int id = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            MainClass.BlueBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEnteries();
            }
        }

        private void LoadEnteries()
        {
            string qry = @"Select * from tblMain m
                                  inner join tblDetails d on m.MainID = d.MainID
                                  inner join products p on p.pID = d.proID
                                    Where m.MainID = " + id + " ";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows[0]["orderType"].ToString() == "배 달")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblDriverName.Visible = false;
            }
            else if(dt2.Rows[0]["orderType"].ToString() == "포 장") 
            {
                btnTake.Checked = true;
                lblWaiter.Visible = false;
                lblDriverName.Visible = false;
            }
            else
            {
                btnDin.Checked = true;
                lblWaiter.Visible = true;
                lblDriverName.Visible = true;
                
            }

            guna2DataGridView1.Rows.Clear ();

            foreach (DataRow item in dt2.Rows) 
            {
                lblDriverName.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();

                string detailid = item["DetaildID"].ToString();
                string proid = item["proID"].ToString();
                string proName = item["pName"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);

            }

            GetTotal();


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToInt32(lblTotal.Text);
            MainClass.BlueBackground(frm);

            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblDriverName.Text = "";
            lblWaiter.Text = "";
            lblDriverName.Visible = false;
            lblWaiter.Visible = false;
            lblDriverName.Text = "00";

        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = ""; // Main table
            string qry2 = ""; // Detail table

            int detailID = 0;

            if(OrderType == "")
            {
                guna2MessageDialog1.Show("주문 타입을 선택해주세요.");
                return;
            }


            if (MainID == 0)  // Insert
            {
                qry1 = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName,  
                            @status, @orderType, @total, @received, @change, @driverID, @CusName, @CusPhone);
                                    Select SCOPE_IDENTITY()";
                
                // 이 행은 최근 추가 값을 가져옴.
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total,  
                                        received = @received, change = @change where MainID = @ID";
            }


            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblDriverName.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); // 주방에 대한 데이터만 저장하면 결제가 들어오면 업데이트됨
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CusName", customerName);
            cmd.Parameters.AddWithValue("@CusPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // 입력
                {
                    qry2 = @"Insert into tblDetails Values( @MainID, @proID, @qty, @price, @amount )";
                }
                else  // 수정
                {
                    qry2 = @" Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                                where DetaildID = @ID ";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

                guna2MessageDialog1.Show("성공적으로 저장 되었습니다!");
                MainID = 0;
                detailID = 0;
                guna2DataGridView1.Rows.Clear();

                lblDriverName.Text = "";
                lblWaiter.Text = "";
                lblDriverName.Visible = false;
                lblWaiter.Visible = false;
                lblDriverName.Text = "00";
                lblDriverName.Text = "";

            }
        }
    }
}
