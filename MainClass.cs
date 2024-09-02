using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace _RM
{
    internal class MainClass
    {

        public static readonly string con_string = "Data Source=PPC; Initial Catalog=RM; Persist Security Info=True; User ID = sa; Password=1234;";
        // 생성한 데이터 베이스와 유저 테이블을 사용하게 함.
        public static SqlConnection con = new SqlConnection(con_string);
        // SqlConnection는 데이터베이스 연결을 관려하는 역할의 클래스임.


        // 유저의 유효성 확인 방법.
        public static bool IsVaildUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from users where username = '" + user + "' and upass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            // SqlCommand 는 데이터베이스에 대해 SQL 명령을 실행하는 데 쓰는 클래스임. 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            // Rows 는 DataTable의 한 속성이며, 이 컬랙션을 통해 DataTable의 각 행에 접근할 수 있음.
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }


            return isValid;
        }

        // 유저네임 프로퍼티 만들기

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) 
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }


            return res;

        }

        // 데이터베이스에서 데이터 로딩하기

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {

            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName = ((DataGridViewTextBoxColumn)lb.Items[i]).Name;
                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            
        }
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlueBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }

        }

        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }



    }
}
