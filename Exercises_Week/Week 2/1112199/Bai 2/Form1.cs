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
namespace Bai_2
{
    public partial class Form1 : Form
    {
        XmlDocument document;
        List<int> List_Result = new List<int>();

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            document = new XmlDocument();
            ofd.Filter = "XML File|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Text_Dir.Text = ofd.FileName;
                document.Load(ofd.FileName);
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlNodeList NodeList = document.DocumentElement.ChildNodes;
            foreach (XmlNode childnode in NodeList)
            {
                Find_Node(childnode);
            }
            string Result_String = "";
            for (int i = 0; i < List_Result.Count; i++)
            {
                Result_String += "  ";
                Result_String += List_Result[i].ToString();
            }
            Text_Result.Text = Result_String;
            button3.Enabled = true;
        }

        void Find_Node(XmlNode p)
        {
            if (p.FirstChild == null)
            {
                List_Result.Add(Convert.ToInt32(p.Attributes["GT"].Value));
            }
            foreach (XmlNode childnode in p)
            {
                Find_Node(childnode);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File|*.xml";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Text_Out.Text = sfd.FileName;
                XmlTextWriter wri = new XmlTextWriter(sfd.FileName, System.Text.Encoding.UTF8);
                wri.WriteStartDocument(true);
                wri.Formatting = Formatting.Indented;
                wri.Indentation = 2;
                Write_File(wri);
                wri.WriteEndDocument();
                wri.Close();
            }
        }

        void Write_File(XmlWriter writer)
        {
            writer.WriteStartElement("DS_Node_La");
            for (int i = 0; i < List_Result.Count; i++)
            {
                writer.WriteStartAttribute("gt" + i.ToString());
                writer.WriteString(List_Result[i].ToString());
                writer.WriteEndAttribute();
            }
            writer.WriteEndElement();
        }
    }
}
