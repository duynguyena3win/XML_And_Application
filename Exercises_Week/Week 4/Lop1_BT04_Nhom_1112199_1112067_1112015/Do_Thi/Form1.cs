using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Do_Thi
{
    public partial class Form1 : Form
    {
        XDocument doc = new XDocument();
        DoThi DOTHI = new DoThi();
        Button[] btnArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "CHỌN DỮ LIỆU ĐƠN XIN PHÉP";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc = XDocument.Load(ofd.FileName);
                Load_DoThi();
            }
        }

        void Load_DoThi()
        {
            XElement Root = doc.Element("DO_THI");
            foreach(XElement node in Root.Elements())
            {
                if (node.Name == "DINH")
                    DOTHI.DS_Dinh.Add(node.Attribute("ten").Value);
                else
                {
                    Canh C = new Canh();
                    C.Ten = node.Attribute("ten").Value;
                    bool left = false;
                    foreach(XElement xnode in node.Elements())
                    {
                        if (left == false)
                        {
                            left = true;
                            C.Dinh1 = xnode.Attribute("ten").Value;
                        }
                        else
                        {
                            C.Dinh2 = xnode.Attribute("ten").Value;
                            left = false;
                        }
                    }
                    DOTHI.DS_Canh.Add(C);
                }
            }
        }

        public void ClickButton(Object sender, System.EventArgs e)
        {
        }

        private void AddButtons(int Num)
        {
            int xPos = 0;
            int yPos = 0;
            int Default_X = panel1.Width / 4;
            int Default_Y = panel1.Height / 3;
            btnArray = new Button[Num];

            for (int i = 0; i < Num; i++)
                btnArray[i] = new System.Windows.Forms.Button();

            int n = 0;

            while (n < Num)
            {
                btnArray[n].Tag = n + 1; // Tag of button 
                btnArray[n].Width = 20; // Width of button 
                btnArray[n].Height = 20; // Height of button 
                if (n == 4) // Location of second line of buttons: 
                {
                    xPos = 0;
                    yPos += Default_Y;
                }
                // Location of button: 
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                // Add buttons to a Panel:

                panel1.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                xPos = xPos + btnArray[n].Width + Default_X; // Left of next button 
            
                btnArray[n].Text = DOTHI.DS_Dinh[n];

                btnArray[n].Click += new System.EventHandler(ClickButton);
                n++;
            }
        }
    }
    public class DoThi
    {
        public List<String> DS_Dinh;
        public List<Canh> DS_Canh;
        public DoThi()
        {
            DS_Dinh = new List<string>();
            DS_Canh = new List<Canh>();
        }
    }
    public class Canh
    {
        public string Ten;
        public string Dinh1, Dinh2;
    }
}
