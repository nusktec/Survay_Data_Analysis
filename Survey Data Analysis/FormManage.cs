using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Survey_Data_Analysis
{
    public partial class FormManage : Form
    {
        //class for xml reading and writting
        XmlClassRW xmlc = new XmlClassRW(Splash_form.fpath, Splash_form.rootName);

        public FormManage()
        {
            InitializeComponent();
            populateData(); //loading printing data
        }

        //Print form data
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        int total_visitors = 0;
        int total_age = 0;
        int male = 0;
        int female = 0;
        int likes = 0;
        //pupulate data
        private void populateData()
        {
            XmlDocument doc = xmlc.readXmlData();
            if (doc != null)
            {
                //ready to read
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("S/N");
                dt.Columns.Add("Name");
                dt.Columns.Add("Sex");
                dt.Columns.Add("Age");
                dt.Columns.Add("Ethnic Group");
                dt.Columns.Add("Disability");
                dt.Columns.Add("Sculpture Like");

                /*
                 *<name>RSC Byte() Limited</name>
                 * <age>6</age>
                 * <sex>1</sex>
                 * <eth>3</eth
                 * <disa>0</disa>
                 * <like>1</like> 
                 */

                //Loop through datas
                foreach (XmlNode nodes in doc.DocumentElement.ChildNodes)
                {
                    //sumup visitors
                    total_visitors++;
                    //declare our model
                    DModel md = new DModel();
                    foreach (XmlNode n in nodes.ChildNodes)
                    {
                        //Calculations
                        if (n.Name == "sex" && Int32.Parse(n.InnerText) == 1)
                        {
                            //count male
                            male += 1;
                        }
                        if (n.Name == "like")
                        {
                            //likes
                            likes += Int32.Parse(n.InnerText);
                        }

                        if (n.Name == "age")
                            //count male
                            total_age += Int32.Parse(n.InnerText);

                        if (n.Name == "name")
                            md.name = n.InnerText;
                        if (n.Name == "age")
                            md.age = int.Parse(n.InnerText);
                        if (n.Name == "sex")
                            md.sex = int.Parse(n.InnerText) == 1 ? "Male" : "Female";
                        if (n.Name == "eth")
                            md.eth = int.Parse(n.InnerText);
                        if (n.Name == "disa")
                            md.disa = int.Parse(n.InnerText);
                        if (n.Name == "like")
                            md.like = int.Parse(n.InnerText);
                        md.sn = total_visitors;
                       
                    }
                    //Pull in data availability
                    object[] o = {total_visitors,md.name,md.sex,md.age,md.eth,md.disa,md.like};
                    dt.Rows.Add(o);
                    //Assign statistical data
                    female = total_visitors - male;
                    lbVisitor.Text = total_visitors.ToString();
                    lbMaleTotal.Text = male.ToString();
                    lbTotalFemale.Text = female.ToString();
                    lbMaleTotal.Text = male.ToString();
                    Decimal laverage = (likes/total_visitors);//likes average
                    Decimal total_age_av = total_age / total_visitors; // age average
                    lbLikesAve.Text = laverage.ToString();
                    lbAgeAverage.Text = total_age_av.ToString();
                }
                dataView.DataSource = dt;
            }
            else
            {
                //not data file exist
                MessageBox.Show("No Data File Exist...Try take a visit survey and try again...");
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //close this form
        }
    }

    // data moddel
    class DModel
    {
        //public getter and setter
        public int sn { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        public String sex { get; set; }
        public int eth { get; set; }
        public int disa { get; set; }
        public int like { get; set; }
    }
}