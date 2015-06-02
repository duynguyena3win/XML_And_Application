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

namespace Xuat_Chieu
{
    public partial class Form1 : Form
    {
        XDocument doc = new XDocument();
        Xuat_Phim XP = new Xuat_Phim();
        Button[] btnArray;
        public Form1()
        {
            InitializeComponent();
        }

        void Load_Data()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "CHỌN CƠ SỠ DỮ LIỆU";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc = XDocument.Load(ofd.FileName);
                Load_Ve();
                XP.Process_Data();
            }
            else
            {
                this.Dispose();
            }
        }

        void Load_Ve()
        {
            XElement Root = doc.Element("XUAT_CHIEU");
            foreach (XElement node in Root.Elements())
            {
                if (node.Name == "PHIM")
                {
                    XP.Ten_Phim = node.Attribute("ten").Value;
                    foreach (XElement ve in node.Elements())
                    {
                        Ve temp = new Ve();
                        temp.Column = Convert.ToInt32(ve.Attribute("cot").Value);
                        temp.Row = Convert.ToInt32(ve.Attribute("dong").Value);
                        if (ve.Attribute("da_ban").Value == "1")
                            temp.Text = "1";
                        else
                            temp.Text = "0";
                        XP.DS_ChoNgoi.Add(temp);
                    }
                }
                else
                    if (node.Name == "THOI_GIAN")
                    {
                        XP.Ngay_Bat_dau = node.Attribute("gio_bat_dau").Value;
                        XP.Ngay_Ket_Thuc = node.Attribute("Gio_ket_thuc").Value;
                    }
            }
        }

        public void ClickButton(Object sender, System.EventArgs e)
        {
            Button But = (Button)sender;
            if (But.Text == "X")
                MessageBox.Show("Vé ngồi ghế này đã bán!");
            else
                MessageBox.Show("Vé ngồi ghế này chưa bán!");
        }

        private void AddButtons()
        {
            int xPos = 0;
            int yPos = 0;

            btnArray = new Button[XP.DS_ChoNgoi.Count];
            
            for (int i = 0; i < XP.DS_ChoNgoi.Count; i++)
                btnArray[i] = new System.Windows.Forms.Button();

            int n = 0;

            while (n < XP.DS_ChoNgoi.Count)
            {
                btnArray[n].Tag = n + 1; // Tag of button 
                btnArray[n].Width = 50; // Width of button 
                btnArray[n].Height = 50; // Height of button 
                if (n == XP.Column) // Location of second line of buttons: 
                {
                    xPos = 0;
                    yPos += 50;
                }
                // Location of button: 
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                // Add buttons to a Panel:
                
                panel2.Controls.Add(btnArray[n]); // Let panel hold the Buttons 
                xPos = xPos + btnArray[n].Width; // Left of next button 
                
                if (XP.DS_ChoNgoi[n].Text == "1")
                {
                    btnArray[n].Text = "X";
                    btnArray[n].BackColor = Color.Red;
                }
                else
                {
                    btnArray[n].Text = "O";
                    btnArray[n].BackColor = Color.CornflowerBlue;
                }

                btnArray[n].Click += new System.EventHandler(ClickButton);
                n++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
            AddButtons();
        }
    }
    public class Xuat_Phim
    {
        public string Ten_Phim, Ngay_Bat_dau, Ngay_Ket_Thuc;
        public int Row, Column;
        public List<Ve> DS_ChoNgoi;
        public Xuat_Phim()
        {
            DS_ChoNgoi = new List<Ve>();
        }
        public void Process_Data()
        {
            Row = DS_ChoNgoi[0].Row;
            Column = DS_ChoNgoi[0].Column;
            for (int i = 0; i < DS_ChoNgoi.Count; i++)
            {
                if (DS_ChoNgoi[i].Row > Row)
                    Row = DS_ChoNgoi[i].Row;
                if (DS_ChoNgoi[i].Column > Column)
                    Column = DS_ChoNgoi[i].Column;
            }
        }
    }

    public class Ve
    {
        public int Row, Column;
        public string Text;
    }
}
