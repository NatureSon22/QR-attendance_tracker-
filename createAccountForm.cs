﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class createAccountForm : Form
    {
        public createAccountForm()
        {
            InitializeComponent();
            createAccount createAccount = new createAccount();
            createAccount.TopLevel = false;
            panel1.Controls.Add(createAccount);
            createAccount.Show();
            guna2Button1.FillColor = ColorTranslator.FromHtml("#00171F");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
