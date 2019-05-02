using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SSCIMS.SubUI
{
    public partial class FormDataMining : Form
    {
        OperationDatabaseClass eOperationDatabaseClass = new OperationDatabaseClass();

        public FormDataMining()
        {
            InitializeComponent();
        }

        private void btnMining_Click(object sender, EventArgs e)
        {
            ArrayList Results = eOperationDatabaseClass.Apriori("DataminingTable", int.Parse(txtSupport.Text.ToString()));
            listboxResults.Items.Clear();
            for (int i = 0; i < Results.Count; i++)
            {
                listboxResults.Items.Add(Results[i].ToString());
            }
        }
    }
}
