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

namespace Bai_6
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        string Ket_Qua1 = "Chúc bạn may mắn lần sau!";
        string Ket_Qua2 = "Bạn đã trúng thưởng:  ";
        bool bool_Trung = false;
        public Form1()
        {
            InitializeComponent();
            Open_KQXS();
        }
        void Open_KQXS()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "THÔNG TIN KẾT QUẢ XỔ SỐ";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Load(ofd.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void Do_So(string VeSo)
        {
            XmlNodeList NodeList = doc.DocumentElement.ChildNodes;
            foreach (XmlNode childnode in NodeList)
            {
                string VeSo_Temp = "";
                for (int i = 0; i < childnode.Attributes.Count; i++)
                {
                    VeSo_Temp = GhepSo(VeSo, childnode.Attributes["gt"+i].Value);
                    if (string.Compare(VeSo, VeSo_Temp) == 0)
                    {
                        bool_Trung = true;
                        Ket_Qua2 += Ket_Qua(childnode.Name);
                    }
                }
            }
        }
        string Ket_Qua(string String_case)
        {
            switch (String_case)
            {
                case "Giai1":
                    return " Giải 1; ";
                case "Giai2":
                    return " Giải 2; ";
                case "Giai3":
                    return " Giải 3; ";
                case "Giai4":
                    return " Giải 4; ";
                case "Giai5":
                    return " Giải 5; ";
                case "Giai6":
                    return " Giải 6; ";
                case "Giai7":
                    return " Giải 7; ";
                case "DacBiet":
                    return " Giải Đặc Biệt; ";
            }
            return null;
        }
        string GhepSo(string VeSo, string Ghep)
        {
            string KQ="";
            int len = 5 - Ghep.Length;
            for (int i = 0; i < len; i++)
                KQ += VeSo[i];

            for (int i = 0; i < Ghep.Length; i++)
                KQ += Ghep[i];

            return KQ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ket_Qua2 = "Bạn đã trúng thưởng:  ";
            Do_So(Text_VeSo.Text);
            if (bool_Trung == true)
                Text_Result.Text = Ket_Qua2;
            else
                Text_Result.Text = Ket_Qua1;
            bool_Trung = false;
        }
    }
}
