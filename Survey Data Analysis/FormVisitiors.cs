using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Data_Analysis
{
    public partial class FormVisitiors : Form
    {
        //reference main form here
        public Splash_form mainForm { get; set; }

        public FormVisitiors()
        {
            InitializeComponent();
        }

        private void FormManage_Load(object sender, EventArgs e)
        {
            //onLoad methods
            //register and bind data
            BringToFront();
        }

        private void FormManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //submit data to db
            if (!checkData())
            {
                MessageBox.Show("Please complete the survey form appropriately !", "Survey");
                return;
            }

        }
        String name; // visitors name
        int likes = 0; //survey report as 1,2,3,4,5
        int age = 0; // age as number
        int sex = 1; //sex (1=male, 2=female)
        int eth = 0; //ethnicity
        int disa = 0; //disability
        private bool checkData()
        {

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the visitors form only 
            //perform applied actions
            Close();
        }

 
    }
}
