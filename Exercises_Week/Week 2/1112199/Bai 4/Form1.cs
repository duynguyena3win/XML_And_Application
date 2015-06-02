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
namespace Bai_4
{
    public partial class Form1 : Form
    {
        XmlDocument document;
        String path;
        public Form1()
        {
            InitializeComponent();
            document = new XmlDocument();
            Load_Xml();
            Combo_GioiTinh.Text = Combo_GioiTinh.Items[0].ToString();
        }

        private void Button_Them_Click(object sender, EventArgs e)
        {
            if (KiemTra() == 0)
            {
                MessageBox.Show("Bổ sung thêm thông tin!");
                return;
            }
            XmlElement nhanvien = document.CreateElement("NhanVien");

            XmlElement hoten = document.CreateElement("HoTen");
            XmlText hotentext = document.CreateTextNode(Text_HoTen.Text);
            hoten.AppendChild(hotentext);

            XmlElement cmnd = document.CreateElement("CMND");
            XmlText cmndtext = document.CreateTextNode(Text_CMND.Text);
            cmnd.AppendChild(cmndtext);

            XmlElement gioitinh = document.CreateElement("GioiTinh");
            XmlText gioitinhtext = document.CreateTextNode(Combo_GioiTinh.Text);
            gioitinh.AppendChild(gioitinhtext);

            XmlElement ngsinh = document.CreateElement("NgSinh");
            XmlText ngsinhtext = document.CreateTextNode(Text_NgSinh.Text);
            ngsinh.AppendChild(ngsinhtext);

            XmlElement luong = document.CreateElement("Luong");
            XmlText luongtext = document.CreateTextNode(Text_Luong.Text);
            luong.AppendChild(luongtext);

            XmlElement diachi = document.CreateElement("DiaChi");
            XmlText diachitext = document.CreateTextNode(Text_DiaChi.Text);
            diachi.AppendChild(diachitext);

            XmlElement donvi = document.CreateElement("DonVi");
            XmlText donvitext = document.CreateTextNode(Text_DonVi.Text);
            donvi.AppendChild(donvitext);

            XmlElement ngbatdau = document.CreateElement("NgBatDauLam");
            XmlText ngbatdautext = document.CreateTextNode(Text_NgBatDau.Text);
            ngbatdau.AppendChild(ngbatdautext);

            XmlElement ngphuthuoc = document.CreateElement("NgPhuThuoc");
            XmlText ngphuthuoctext = document.CreateTextNode(Text_PhThuoc.Text);
            ngphuthuoc.AppendChild(ngphuthuoctext);

            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(cmnd);
            nhanvien.AppendChild(gioitinh);
            nhanvien.AppendChild(ngsinh);
            nhanvien.AppendChild(luong);
            nhanvien.AppendChild(diachi);
            nhanvien.AppendChild(donvi);
            nhanvien.AppendChild(ngbatdau);
            nhanvien.AppendChild(ngphuthuoc);
            document.DocumentElement.AppendChild(nhanvien);
            document.Save(path);
            
            MessageBox.Show("Đã lưu thành công " + Text_HoTen.Text);
            Xoa_Trang();
        }
        int KiemTra()
        {
            if(Text_CMND.Text == "" || Text_DiaChi.Text == "" || Text_DonVi.Text == "" ||
                Text_HoTen.Text == "" || Text_Luong.Text == "" || Text_NgBatDau.Text == "" ||
                    Text_NgSinh.Text == "" || Text_PhThuoc.Text == "")
            return 0;
            return 1;
        }
        void Xoa_Trang()
        {
            Text_CMND.Text = "";
            Text_DiaChi.Text = "";
            Text_DonVi.Text = "";
            Text_HoTen.Text = "";
            Text_Luong.Text = "";
            Text_NgBatDau.Text = "";
            Text_NgSinh.Text = "";
            Text_PhThuoc.Text = "";
            Combo_GioiTinh.Text = Combo_GioiTinh.Items[0].ToString();
        }

        void Load_Xml()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "Chọn Tập Tin Dữ Liệu XML";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName;
                document.Load(ofd.FileName);
            }
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            Xoa_Trang();
        }
    }
}
