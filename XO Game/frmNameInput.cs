using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class frmNameInput : Form
    {
        public frmNameInput()
        {
            InitializeComponent();
        }

        public String PlayerName
        {
            get
            {
                return txtName.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNameInput_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Focus();
        }

    }
}
