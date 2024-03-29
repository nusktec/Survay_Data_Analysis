﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Survey_Data_Analysis
{
    public partial class Splash_form : Form
    {
        //static variables for global usage
        static public String fpath = "survey.db";
        static public String rootName = "visitors";

        public Splash_form()
        {
            InitializeComponent();
        }

        //Close the main window
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Form visitorForm = new FormVisitiors();
            //additional data
            
            if (visitorForm.ShowDialog() == DialogResult.OK)
            {
                //restor back
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Admin Area", "Enter Protected Password", "", -1, -1);
            if (input == "admin")
            {
                //open management form
                new FormManage().Show();
            }
            else
            {
                MessageBox.Show("Invalid password, try again !", "Password");
            }
        }
    }
}
