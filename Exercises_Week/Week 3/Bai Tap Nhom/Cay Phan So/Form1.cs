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

namespace Cay_Phan_So
{
    public partial class Form1 : Form
    {
        string temp;
        XmlDocument doc = new XmlDocument();
        PhanSo PS = new PhanSo();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void Write_Data()
        {
            XmlNodeList NodeList = doc.DocumentElement.ChildNodes;
            XmlNode Node = doc.DocumentElement.FirstChild;
            foreach (XmlNode childnode in NodeList)
            {
                i = 0;
                temp += childnode.Attributes["tu"].Value + "/" + childnode.Attributes["mau"].Value + Environment.NewLine;
                Find_Node(childnode);
            }
        }
        
        void Find_Node(XmlNode p)
        {
            i++;
            if (p.FirstChild == null)
            {
                return;
            }
            
            foreach (XmlNode childnode in p)
            {
                
                for (int j = 0; j < i; j++)
                    temp += "\r\t";
                temp += childnode.Attributes["tu"].Value + "/" + childnode.Attributes["mau"].Value + Environment.NewLine;
                Find_Node(childnode);
                i--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "Mở Dữ Liệu";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Load(ofd.FileName);
                Write_Data();
                textBox1.Text = temp;
            }
        }
    }

    public class PhanSo
    {
        public int tu, mau;
        public PhanSo()
        {
            tu = mau = 0;
        }
    }
}
