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
    class XmlClassRW
    {

        //Initialize it
        private String fileName, rootName;
        public XmlClassRW(String filePathName, String rootName)
        {
            this.fileName = filePathName;
            this.rootName = rootName;
           
        }

        //XML Writter
        public void writeXmlData(String nodeName, Dictionary<Object, Object> data)
        {
            try
            {
                var filePath = fileName;
                var xmlDoc = XDocument.Load(filePath);

                var parentElement = new XElement(nodeName);

                //Iterate and save
                foreach (KeyValuePair<Object, Object> v in data)
                {
                    //iterate data and append//
                    parentElement.Add(new XElement((String)v.Key, v.Value));

                }

                var rootElement = xmlDoc.Element(rootName);
                rootElement?.Add(parentElement);

                xmlDoc.Save(fileName);
            }
            catch (Exception err)
            {
                //First mount
                MessageBox.Show("Database created, please re-save and continue...");
                using (XmlWriter writer = XmlWriter.Create(fileName))
                {
                    writer.WriteStartElement(rootName);
                    writer.WriteEndElement();
                    writer.Flush();
                    err.ToString();
                }
            }
        }

        //Reader
        public XmlDocument readXmlData()
        {
            if (System.IO.File.Exists(fileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                //assume it's loadedd
                return doc;
            }
            return null;
        }
    }
}
