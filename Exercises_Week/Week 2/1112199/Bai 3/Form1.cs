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

namespace Bai_3
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        int[,] Array;
        int dong, cot;
        public Form1()
        {
            InitializeComponent();
            Button_Save_2.Enabled = Button_Save_3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "ĐỌC MA TRẬN 1";
            ofd.Filter = "XML File|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Load(ofd.FileName);
                Get_Matrix();
                Button_Save_2.Enabled = Button_Save_3.Enabled = true;
            }

        }
        void Get_Matrix()
        {
            XmlElement matran = (XmlElement)doc.SelectSingleNode("/MaTran");
            dong =int.Parse(matran.GetAttribute("dong"));
            cot=int.Parse(matran.GetAttribute("cot"));
            Array = new int[dong,cot];
            XmlNodeList NodeList = doc.DocumentElement.ChildNodes;
            foreach (XmlNode childnode in NodeList)
            {
                int i_dong = Convert.ToInt32(childnode.Attributes["dong"].Value);
                int i_cot = Convert.ToInt32(childnode.Attributes["cot"].Value);
                int i_giatri = Convert.ToInt32(childnode.Attributes["giatri"].Value);
                Array[i_dong-1, i_cot-1] = i_giatri;
            }

        }

        private void Button_Save_2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File|*.xml";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlTextWriter wri = new XmlTextWriter(sfd.FileName, System.Text.Encoding.UTF8);
                wri.WriteStartDocument(true);
                wri.Formatting = Formatting.Indented;
                wri.Indentation = 2;
                Save_Way_2(wri);
                wri.WriteEndDocument();
                wri.Close();
            }
        }

        void Save_Way_2(XmlTextWriter writer)
        {
            writer.WriteStartElement("MaTran");

            writer.WriteStartAttribute("cot");
            writer.WriteString(cot.ToString());
            writer.WriteEndAttribute();

            for (int i = 0; i < dong; i++)
            {
                writer.WriteStartElement("Dong");
                for (int j = 0; j < cot; j++)
                {
                    writer.WriteStartElement("SoNguyen");
                    writer.WriteStartAttribute("giatri");
                    writer.WriteString(Array[i,j].ToString());
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }

        void Save_Way_3(XmlTextWriter writer)
        {
            writer.WriteStartElement("MaTran");

            writer.WriteStartAttribute("dong");
            writer.WriteString(dong.ToString());
            writer.WriteEndAttribute();

            for (int j = 0; j < cot; j++)
            {
                writer.WriteStartElement("Cot");
                for (int i = 0; i < dong; i++)
                {
                    writer.WriteStartElement("SoNguyen");
                    writer.WriteStartAttribute("giatri");
                    writer.WriteString(Array[i, j].ToString());
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }

        private void Button_Save_3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File|*.xml";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlTextWriter wri = new XmlTextWriter(sfd.FileName, System.Text.Encoding.UTF8);
                wri.WriteStartDocument(true);
                wri.Formatting = Formatting.Indented;
                wri.Indentation = 2;
                Save_Way_3(wri);
                wri.WriteEndDocument();
                wri.Close();
            }
        }
    }
}
