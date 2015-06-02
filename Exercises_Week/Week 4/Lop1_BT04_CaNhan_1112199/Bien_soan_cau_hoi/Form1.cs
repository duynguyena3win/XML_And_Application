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
using System.Xml.Linq;
using System.IO;
namespace Bien_soan_cau_hoi
{
    public partial class Form1 : Form
    {
        XElement Root_CauHoi;
        XElement Root_DapAn;
        XDocument doc = new XDocument();
        XDocument doc_DA = new XDocument();
        bool Checked_Radio = true;

        public Form1()
        {
            InitializeComponent();
            Radio_A.Checked = false;
        }

        void Save_File()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File|*.xml";
            sfd.Title = "LƯU FILE DỮ LIỆU XML";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool bool_check = false;
                string path = Path.GetDirectoryName(sfd.FileName) + "\\DapAn.xml";
                try
                {
                    doc = XDocument.Load(sfd.FileName);
                    XElement temp = doc.Element("DANH_SACH_DE");
                    foreach (XElement dx in temp.Elements("DE"))
                    {
                        if (dx.Attribute("ma_de").Value == Root_CauHoi.Attribute("ma_de").Value)
                        {
                            bool_check = true;
                            foreach (XElement cau in Root_CauHoi.Elements("CAU"))
                            {
                                dx.Add(cau);
                            }
                            break;
                        }
                    }
                    if(bool_check == false)
                        temp.Add(Root_CauHoi);
                    doc.Save(sfd.FileName);
                }
                catch
                {
                    XElement DS_De = new XElement("DANH_SACH_DE");
                    DS_De.Add(Root_CauHoi);
                    DS_De.Save(sfd.FileName);
                }

                try
                {
                    doc_DA = XDocument.Load(path);
                    XElement Node_DA = doc_DA.Element("DANH_SACH_DE");
                    foreach (XElement dx in Node_DA.Elements("DE"))
                    {
                        if (dx.Attribute("ma_de").Value == Root_DapAn.Attribute("ma_de").Value)
                        {
                            bool_check = true;
                            foreach (XElement cau in Root_DapAn.Elements("CAU"))
                            {
                                dx.Add(cau);
                            }
                            break;
                        }
                    }
                    if (bool_check == false)
                        Node_DA.Add(Root_DapAn);
                    doc_DA.Save(path);
                }
                catch
                {
                    XElement DS_De1 = new XElement("DANH_SACH_DE");
                    DS_De1.Add(Root_DapAn);
                    DS_De1.Save(path);
                }
            }
        }

        private void Text_Made_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_BD_Click(object sender, EventArgs e)
        {
            if (Check_Text() == true)
            {
                Text_Made.Enabled = false;
                Button_Save1.Enabled = true;
                groupBox1.Enabled = true;
                Button_BD.Enabled = false;
                Checked_Radio = false;
                Root_CauHoi = new XElement("DE", new XAttribute("ma_de", Text_Made.Text));
                Root_DapAn = new XElement("DE", new XAttribute("ma_de", Text_Made.Text));
            }
        }

        bool Check_Text()
        {
            try
            {
                Convert.ToInt32(Text_Made.Text);
            }
            catch
            {
                MessageBox.Show("Mả đề là một số nguyên", "Thông báo");
                return false;
            }
            return true;
        }

        void Create_XML_Question()
        {
            XElement CAU = new XElement("CAU", new XAttribute("cau_hoi",Text_CH.Text),
                                    new XElement("DAP_AN",
                                        new XAttribute("a",Text_A.Text),
                                        new XAttribute("b",Text_B.Text),
                                        new XAttribute("c",Text_C.Text),
                                        new XAttribute("d",Text_D.Text)));
            Root_CauHoi.Add(CAU);
            XElement DA = new XElement("CAU", new XAttribute("dap_an", String_Answer()));
            Root_DapAn.Add(DA);
        }

        bool Check_Question()
        {
            if (Text_CH.Text != "" && Text_A.Text != "" && Text_B.Text != "" && Text_C.Text != "" && Text_D.Text != "")
                return true;
            return false;
        }

        private void Button_Save1_Click(object sender, EventArgs e)
        {
            Button_BD.Enabled = true;
            groupBox1.Enabled = false;
            this.Dispose();
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            Text_CH.Text = Text_A.Text = Text_B.Text = Text_C.Text = Text_D.Text = "";
            Radio_A.Checked = true;
            Checked_Radio = false;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Checked_Radio == true)
            {
                Create_XML_Question();
                this.Button_Del_Click(null, null);
                Checked_Radio = false;
                MessageBox.Show("Đã lưu thành công !", "Thông báo");
            }
            else
                MessageBox.Show("Chọn đáp án cho câu hỏi vừa nhập!", "Thông báo");
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult temp = MessageBox.Show("Nếu Thoát toàn bộ dữ liệu sẽ bị mất!\r\nBạn có muốn lưu trước khi Thoát?","Thông báo",MessageBoxButtons.YesNoCancel);
            if( temp == System.Windows.Forms.DialogResult.Yes)
            {
                Button_Save_Data_Click(null, null);
            }
            else
                if (temp == System.Windows.Forms.DialogResult.No)
                {
                    Root_CauHoi = null;
                    groupBox1.Enabled = false;
                    Text_Made.Text = "";
                    Text_Made.Enabled = true;
                    Button_BD.Enabled = true;
                    Checked_Radio = false;
                }
        }

        private void Button_Save_Data_Click(object sender, EventArgs e)
        {
            Save_File();
            Button_Del_Click(null, null);
            groupBox1.Enabled = false;
            Text_Made.Text = "";
            Text_Made.Enabled = true;
            Button_BD.Enabled = true;
            Checked_Radio = false;
        }

        string String_Answer()
        {
            if (Radio_A.Checked == true)
                return "a";
            else
                if (Radio_B.Checked == true)
                    return "b";
                else
                    if (Radio_C.Checked == true)
                        return "c";
                    else
                        if (Radio_D.Checked == true)
                            return "d";
            return "-";
        }

        private void Radio_A_CheckedChanged(object sender, EventArgs e)
        {
            Checked_Radio = true;
        }
    }

    public class Cauhoi
    {
        public string Cau_hoi;
        public string a, b, c, d;

        public Cauhoi()
        {
            Cau_hoi = a = b = c = d = "";
        }

        public void Get_Value(string cau, string A, string B, string C, string D)
        {
            Cau_hoi = cau;
            a = A;
            b = B;
            c = C;
            d = D;
        }
    }

    public class DapAn
    {
        public List<string> Dap_An;
        public float Score = 0;
        public DapAn()
        {
            Dap_An = new List<string>();
        }
    }
}
