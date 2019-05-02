using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSCIMS
{
    public partial class FormLogin : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string WhereString = "UserName = '" + txtUserName.Text.ToString() + "' and [Password] = '" + txtPassword.Text.ToString() + "'";

            if (eOperationDatabaseClass.Query("[User]", "*", WhereString).Table.Rows.Count == 1)
            {
                this.Hide();

                #region 传统主菜单设置方式
                FormHome eFormHome = new FormHome(txtUserName.Text.ToString());
                eFormHome.ShowDialog();
                #endregion

                #region 树型主菜单方式
                //FormHomeTreeView eFormHomeTreeView = new FormHomeTreeView(txtUserName.Text.ToString());
                //eFormHomeTreeView.ShowDialog();
                #endregion

                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
