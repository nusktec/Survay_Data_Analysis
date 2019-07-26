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
                MessageBox.Show("Please complete the survey form appropriately !" + likes, "Survey");
                writeData();
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
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the visitors form only 
            //perform applied actions
            Close();
        }

        //XML Writter
        public void writeData()
        {
           try
            {
                var filePath = "books.xml";
                var xmlDoc = XDocument.Load(filePath);
                var parentElement = new XElement("Student");
                var firstNameElement = new XElement("FirstName", "Onuhe");
                var lastNameElement = new XElement("LastName", "Ameh K");

                parentElement.Add(firstNameElement);
                parentElement.Add(lastNameElement);

                var rootElement = xmlDoc.Element("School");
                rootElement?.Add(parentElement);

                xmlDoc.Save("books.xml");
            }catch (Exception ex)
            {
                using (XmlWriter writer = XmlWriter.Create("books.xml"))
                {
                    writer.WriteStartElement("School");

                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }
 
    }
}
