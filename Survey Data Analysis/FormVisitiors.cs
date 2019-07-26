using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;

namespace Survey_Data_Analysis
{
    public partial class FormVisitiors : Form
    {
        //Writer class
        XmlClassRW xmlc = new XmlClassRW("survey.db", "visitors");

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
            //send to xml files
            Dictionary<Object, Object> rd = new Dictionary<object, object>();
            rd.Add("name", name);
            rd.Add("age", age);
            rd.Add("sex", sex);
            rd.Add("eth", eth);
            rd.Add("disa", disa);
            rd.Add("like", likes);
            xmlc.writeXmlData("visitor", rd);
            MessageBox.Show("Survey recorded, Goodbye for today...", "Thank you !");
            //clear data
            txtBoxName.Clear();
            numAge.Value = 0;
            Close();
        }

        String name; // visitors name
        int likes = 0; //survey report as 1,2,3,4,5
        int age = 0; // age as number
        int sex = 0; //sex (1=male, 2=female)
        int eth = 0; //ethnicity
        int disa = 0; //disability
        private bool checkData()
        {
            name = this.txtBoxName.Text;
            age = (int)this.numAge.Value;
            sex = this.comSex.SelectedIndex;
            eth = this.comEth.SelectedIndex;
            disa = this.checkDis.Checked ? 1 : 0;
            //generate likes
            foreach(Control c in this.boxSurvey.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked)
                    {
                        likes = rb.TabIndex;
                    }
                }
            }
            //filter ddata needs
            if(name=="" || age==0 || sex==0 || eth==0 || likes == 0)
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the visitors form only 
            //perform applied actions
            Close();
        }
 
    }
}
