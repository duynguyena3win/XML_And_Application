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
using System.IO;
namespace Bai_1
{
    public partial class Form1 : Form
    {
        PhuongTrinh PTB2 = new PhuongTrinh();
        XmlDocument document;
        int state;
        public Form1()
        {
            InitializeComponent();
            Button_Cal.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            document = new XmlDocument();
            ofd.Filter = "XML File|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Text_Dir.Text = ofd.FileName;
                document.Load(ofd.FileName);
                XmlElement Duong_tron = (XmlElement)document.SelectSingleNode("/PhuongTrinh");
                Button_Cal.Enabled = true;
                PTB2.a = int.Parse(Duong_tron.GetAttribute("a"));
                PTB2.b = int.Parse(Duong_tron.GetAttribute("b"));
                PTB2.c = int.Parse(Duong_tron.GetAttribute("c"));
                ShowValues();
            }
        }

        void ShowValues()
        {
            Text_A.Text = PTB2.a.ToString();
            Text_B.Text = PTB2.b.ToString();
            Text_C.Text = PTB2.c.ToString();
        }
        void ShowResult()
        {
            Text_X1.Text = PTB2.x1.ToString();
            Text_X2.Text = PTB2.x2.ToString();
        }
        int Calculation()
        {
            double delta = PTB2.b * PTB2.b - 4 * PTB2.a * PTB2.c;
            if (delta < 0)
            {
                Text_X1.Text = "Không nghiệm";
                Text_X2.Text = "Không nghiệm";
                return -1;
            }
            else
                if (delta == 0)
                {
                    PTB2.x1 = PTB2.x2 = (0 - PTB2.b) / 2 * PTB2.a;
                    ShowResult();
                    return 0;
                }
                else
                {
                    PTB2.x1 = (0 - PTB2.b + Math.Sqrt(delta)) / 2 * PTB2.a;
                    PTB2.x2 = (0 - PTB2.b - Math.Sqrt(delta)) / 2 * PTB2.a;
                    ShowResult();
                    return 1;
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

                createNode(PTB2, wri);
                wri.WriteEndDocument();
                wri.Close();
            }
        }

        
        void createNode(PhuongTrinh P, XmlTextWriter writer)
        {
            writer.WriteStartElement("PhuongTrinh");

            writer.WriteStartAttribute("a");
            writer.WriteString(P.a.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("b");
            writer.WriteString(P.b.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("c");
            writer.WriteString(P.c.ToString());
            writer.WriteEndAttribute();

            if (state != -1)
            {
                writer.WriteStartAttribute("x1");
                writer.WriteString(P.x1.ToString());
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("x2");
                writer.WriteString(P.x2.ToString());
                writer.WriteEndAttribute();
            }

            writer.WriteEndElement();
            
        }
        private void Button_Cal_Click(object sender, EventArgs e)
        {
            state = Calculation();
        }

    }

    public partial class PhuongTrinh
    {
        public int a;
        public int b;
        public int c;
        public double x1;
        public double x2;

        public PhuongTrinh()
        {
            a = b = c = 0;
        }
    }
}