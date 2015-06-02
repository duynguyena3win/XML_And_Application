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
namespace Giao_Vien
{
    public partial class Form1 : Form
    {
        GiaoVien GV = new GiaoVien();
        XmlDocument doc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "Mở Dữ Liệu";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Load(ofd.FileName);
                Write_Data();
                Text_Box.Text = Get_String();
            }
        }

        void Write_Data()
        {
            
            XmlElement GVien = (XmlElement) doc.SelectSingleNode("/GIAO_VIEN");
            GV.Hoten = GVien.Attributes["hoten"].Value;
            XmlNodeList NodeList = doc.DocumentElement.ChildNodes;
            XmlNode Node = doc.DocumentElement.FirstChild;
            foreach (XmlNode childnode in NodeList)
            {
                if (childnode.Name == "MON_HOC")
                    GV.DS_Monhoc.Add(childnode.Attributes["ten"].Value);
                
                if (childnode.Name == "THOI_GIAN_RANH")
                {
                    BuoiRanh BR = new BuoiRanh();
                    BR.Buoi = childnode.Attributes["buoi"].Value;
                    BR.Thu = childnode.Attributes["thu"].Value;
                    GV.DS_Buoiranh.Add(BR);
                }

            }
        }

        string Get_String()
        {
            string temp = "Giáo viên: " + GV.Hoten + Environment.NewLine;
            temp += "Danh sách môn học có khả năng dạy" + Environment.NewLine;
            for (int i = 0; i < GV.DS_Monhoc.Count; i++)
                temp += GV.DS_Monhoc[i] + Environment.NewLine;
            temp += "Danh sách buổi rảnh trong tuần" + Environment.NewLine;
            for (int i = 0; i < GV.DS_Buoiranh.Count; i++)
                temp += GV.DS_Buoiranh[i].Buoi + "\r\t" + GV.DS_Buoiranh[i].Thu + Environment.NewLine;
            return temp;
        }
    }

    public class BuoiRanh
    {
        public string Thu;
        public string Buoi;
        public BuoiRanh()
        {
            Thu = Buoi = "";
        }
    }

    public class GiaoVien
    {
        public string Hoten;
        public List<string> DS_Monhoc;
        public List<BuoiRanh> DS_Buoiranh;
        public GiaoVien()
        {
            Hoten = "";
            DS_Monhoc = new List<string>();
            DS_Buoiranh = new List<BuoiRanh>();
        }
    }
}
