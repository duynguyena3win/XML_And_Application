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

namespace Nhan_Vien_Cong_Ty
{
    public partial class Form1 : Form
    {
        XDocument doc = new XDocument();
        List<Nhan_Vien> DS_NV;
        int Current_Index = 0;
        public Form1()
        {
            InitializeComponent();
            DS_NV = new List<Nhan_Vien>();
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (++Current_Index > DS_NV.Count-1)
                Current_Index = 0;
            Load_Data_To_Control(Current_Index);
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (--Current_Index < 0)
                Current_Index = DS_NV.Count - 1;
            Load_Data_To_Control(Current_Index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn cơ sỡ dữ liệu cho chương trình!", "Thông báo");
            Load_Data();
            Load_Data_To_Control(Current_Index);
        }
        void Load_Data_To_Control(int n)
        {
            Combo_List_Company.Items.Clear();
            Text_Hoten.Text = DS_NV[n].Hoten;
            Text_Add.Text = DS_NV[n].DiaChi;
            Text_Luong.Text = DS_NV[n].Luong;
            Text_CMND.Text = DS_NV[n].CMND;
            for (int i = 0; i < DS_NV[n].DS_DonVi.Count; i++)
                Combo_List_Company.Items.Add(DS_NV[n].DS_DonVi[i].Ten);
            Combo_List_Company.SelectedIndex = 0;
            DateTime_Birthday.Value = DS_NV[n].Ngay_sinh;
            DateTime_Day.Value = DS_NV[n].Ngay_bat_dau;
            Number_Human.Value = DS_NV[n].So_ng_phu_thuoc;
        }
        void Load_Data()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "CHỌN CƠ SỠ DỮ LIỆU";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc = XDocument.Load(ofd.FileName);
                Load_NhanVien();
            }
            else
            {
                this.Dispose();
            }
        }

        void Load_NhanVien()
        {
            XElement Root = doc.Element("CONG_TY");
            foreach (XElement node in Root.Elements())
            {
                if (node.Name == "NHAN_VIEN")
                {
                    Nhan_Vien NV = new Nhan_Vien();
                    NV.Hoten = node.Attribute("hoten").Value;
                    NV.Gioi_tinh = node.Attribute("gioi_tinh").Value;
                    NV.Ngay_sinh = Convert.ToDateTime(node.Attribute("ngay_sinh").Value.ToString());
                    NV.Ngay_bat_dau = Convert.ToDateTime(node.Attribute("ngay_bat_dau").Value);
                    NV.CMND = node.Attribute("cmnd").Value;
                    NV.Luong = node.Attribute("luong").Value;
                    NV.So_ng_phu_thuoc = Convert.ToInt32(node.Attribute("so_ng_phu_thuoc").Value);
                    NV.DiaChi = node.Attribute("dia_chi").Value;
                    foreach (XElement donvi in node.Elements())
                    {
                        Don_Vi DV = new Don_Vi(donvi.Attribute("ten").Value);
                        NV.DS_DonVi.Add(DV);
                    }
                    DS_NV.Add(NV);
                    
                }
            }
        }
    }
    public class Nhan_Vien
    {
        public string Hoten, Gioi_tinh, CMND, Luong, DiaChi;
        public int So_ng_phu_thuoc;
        public DateTime Ngay_sinh, Ngay_bat_dau;
        public List<Don_Vi> DS_DonVi;

        public Nhan_Vien()
        {
            DS_DonVi = new List<Don_Vi>();
            Ngay_sinh = new DateTime();
            Ngay_bat_dau = new DateTime();
        }
    }

    public class Don_Vi
    {
        public string Ten;
        public Don_Vi(string ten)
        {
            Ten = ten;
        }
    }
}
