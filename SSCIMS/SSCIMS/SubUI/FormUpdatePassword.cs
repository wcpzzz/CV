using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLayout;

namespace SSCIMS
{
    public partial class FormUpdatePassword : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        AutoSizeFormClass eAutoSizeFormClass = new AutoSizeFormClass();

        string LoginUserName = null;

        public FormUpdatePassword()
        {
            InitializeComponent();
        }

        public FormUpdatePassword(string LoginUser)
        {
            InitializeComponent();
            LoginUserName = LoginUser;
        }

        private void FormUpdatePassword_Layout(object sender, LayoutEventArgs e)
        {
            eAutoSizeFormClass.controlAutoSize(this, false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.ToString().Trim() == eOperationDatabaseClass.Query("[User]", "[Password]", "UserName = '" + LoginUserName + "'").Table.Rows[0][0].ToString().Trim())
            {
                if (txtNewPasswordFirst.Text.ToString() == txtNewPasswordAgain.Text.ToString())
                {
                    eOperationDatabaseClass.Update("[User]", "UserName = '" + LoginUserName + "'", "[Password] = '" + txtNewPasswordFirst.Text.ToString() + "'", true);
                }
                else
                {
                    ePUpdatePassword.SetError(txtNewPasswordAgain, "重输密码错误！");
                }
            }
            else
            {
                ePUpdatePassword.SetError(txtOldPassword, "旧密码输入错误！");
            }
            txtNewPasswordAgain.Clear();
            txtNewPasswordFirst.Clear();
            txtOldPassword.Clear();
            ePUpdatePassword.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNewPasswordAgain.Clear();
            txtNewPasswordFirst.Clear();
            txtOldPassword.Clear();
            ePUpdatePassword.Clear();
        }
    }
}
