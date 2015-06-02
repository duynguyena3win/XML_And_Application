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

namespace Nhan_Vien_Ngoai_Ngu
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        NVNN NV = new NVNN();
        public Form1()
        {
            InitializeComponent();
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

        string Get_String()
        {
            string temp = "Nhân viên: " + NV.hoten + Environment.NewLine;
            temp += "Ngoại ngữ có thể sữ dụng: ";
            for (int i = 0; i < NV.So_NgoaiNgu.Count - 1; i++)
            {
                temp += NV.So_NgoaiNgu[i].ten + ", ";
            }
            temp += NV.So_NgoaiNgu[NV.So_NgoaiNgu.Count-1].ten;
            return temp;
        }
        void Write_Data()
        {

            XmlElement Node_parent = (XmlElement)doc.SelectSingleNode("/NHAN_VIEN");

            NV.hoten = Node_parent.Attributes["hoten"].Value;
            NV.gioitinh = Node_parent.Attributes["gioi_tinh"].Value;
            NV.mucluong = Node_parent.Attributes["luong"].Value;
            NV.cmnd = Node_parent.Attributes["cmnd"].Value;
            NV.ngay_batdau = Node_parent.Attributes["ngay_batdau"].Value;
            NV.ng_phuthuoc = Convert.ToInt32(Node_parent.Attributes["nguoi_phuthuoc"].Value);

            
            XmlNodeList NodeList = doc.DocumentElement.ChildNodes;
            XmlNode Node = doc.DocumentElement.FirstChild;
            foreach (XmlNode childnode in NodeList)
            {
                if (childnode.Name == "NGOAI_NGU")
                {
                    NgoaiNgu nn = new NgoaiNgu();
                    nn.ten = childnode.Attributes["ten"].Value;
                    NV.So_NgoaiNgu.Add(nn);
                }
            }
        }
    }

    public class NgoaiNgu
    {
        public string ten;
        public NgoaiNgu()
        {
            ten = "";
        }
    }

    public class NVNN
    {
        public string hoten, gioitinh, cmnd, mucluong, ngay_batdau;
        public int ng_phuthuoc;
        public List<NgoaiNgu> So_NgoaiNgu;
        public NVNN()
        {
            So_NgoaiNgu = new List<NgoaiNgu>();
        }
    }
}