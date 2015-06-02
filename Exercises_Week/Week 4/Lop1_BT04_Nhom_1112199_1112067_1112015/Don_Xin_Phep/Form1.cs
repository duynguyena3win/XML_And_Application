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

namespace Don_Xin_Phep
{
    public partial class Form1 : Form
    {
        XDocument doc = new XDocument();
        List<Don_Xin_Phep> DS_DXP;
        int Current_Index = 0;
        public Form1()
        {
            InitializeComponent();
            DS_DXP = new List<Don_Xin_Phep>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn bộ cơ sỡ dữ liệu!","Thông báo");
            Load_Data();
            Load_Data_To_Control(Current_Index);
        }

        void Load_Data_To_Control(int n)
        {
            for (int i = 0; i < Combo_LyDo.Items.Count; i++)
                if (Combo_LyDo.Items[i].ToString() == DS_DXP[n].LyDo)
                    Combo_LyDo.SelectedIndex = i;

            Text_Hoten.Text = DS_DXP[n].Hoten;
            Text_CMND.Text = DS_DXP[n].CMND;
            Text_DonVi.Text = DS_DXP[n].DonVi;
            Text_Ngay.Text = DS_DXP[n].Ngay.ToString();
            DateTime_Start_Day.Value = DS_DXP[n].Ng_Bat_Dau;
        }

        void Load_Data()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "CHỌN DỮ LIỆU ĐƠN XIN PHÉP";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc = XDocument.Load(ofd.FileName);
                XElement Root = doc.Element("CONG_TY");
                foreach (XElement node in Root.Elements())
                {
                    Don_Xin_Phep DXP = new Don_Xin_Phep();
                    if (node.Name == "DON_XIN_NGHI")
                    {
                        DXP.Ngay = Convert.ToInt32(node.Attribute("so_ngay").Value);
                        DXP.Ng_Bat_Dau = Convert.ToDateTime(node.Attribute("ngay_bat_dau").Value);
                        foreach (XElement xnode in node.Elements())
                        {
                            if (xnode.Name == "NHAN_VIEN")
                            {
                                DXP.Hoten = xnode.Attribute("hoten").Value;
                                DXP.CMND = xnode.Attribute("cmnd").Value;
                                foreach (XElement xxnode in xnode.Elements("DON_VI"))
                                    DXP.DonVi = xxnode.Attribute("ten").Value;
                            }
                            if (xnode.Name == "LY_DO")
                            {
                                DXP.LyDo = xnode.Attribute("ten").Value;
                            }
                        }
                        DS_DXP.Add(DXP);
                    }

                    if (node.Name == "LY_DO")
                        Combo_LyDo.Items.Add(node.Attribute("ten").Value);
                }
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (++Current_Index > DS_DXP.Count - 1)
                Current_Index = 0;
            Load_Data_To_Control(Current_Index);
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (--Current_Index < 0)
                Current_Index = DS_DXP.Count - 1;
            Load_Data_To_Control(Current_Index);
        }
    }
    public class Don_Xin_Phep
    {
        public string Hoten, CMND, DonVi, LyDo;
        public int Ngay;
        public DateTime Ng_Bat_Dau;

        public Don_Xin_Phep()
        {
            Ng_Bat_Dau = new DateTime();
        }

        public Don_Xin_Phep(string hoten, string cmnd, string donvi, string ngay, string LyDo, string datetime)
        {
            Hoten = hoten;
            CMND = cmnd;
            DonVi = donvi;
            Ngay = Convert.ToInt32(ngay);
            Ng_Bat_Dau = Convert.ToDateTime(datetime);
        }
    }
}
