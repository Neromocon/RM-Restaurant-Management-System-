using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _RM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 데이터 베이스를 만들고 유저 테이블을 만들어 사용.

            if (MainClass.IsVaildUser(txtUser.Text, txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("아이디와 비밀번호를 다시 한 번 확인해 주세요.");
                return;
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }

            // 유저 정보를 먼저 입력.

        }


        // PW의 textbox에 포커스가 있을 때, enter를 입력하면 btnLogin버튼이 클릭됨.
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btnLogin_Click(sender, e);
                if (MainClass.IsVaildUser(txtUser.Text, txtPass.Text) == false)
                {
                    guna2MessageDialog1.Show("아이디와 비밀번호를 다시 한 번 확인해 주세요.");
                    return;
                }
                else
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                }
            }


        }

    }
}
