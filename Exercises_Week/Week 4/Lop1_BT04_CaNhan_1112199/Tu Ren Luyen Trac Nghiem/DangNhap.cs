using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tu_Ren_Luyen_Trac_Nghiem
{
    public partial class DangNhap : Form
    {
        public string Hoten;
        public string MSSV;
        public string Ma_De;
        public string Path_XML_File;
        public string Path_XML_DapAn;
        int stt;
        bool bool_close = false;
        public DangNhap()
        {
            InitializeComponent();
            Hoten = MSSV = "";
            stt = 0;
            Path_XML_File = "";
            Load_DS_De();
        }

        void Load_DS_De()
        {
            MessageBox.Show("Chọn file chứa bộ đề thi trắc nghiệm!", "Yêu cầu");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File| *.xml";
            ofd.Title = "CHỌN BỘ ĐỀ TRẮC NGHIỆM";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path_XML_File = ofd.FileName;
                Path_XML_DapAn = ofd.FileName.Replace(ofd.SafeFileName, "DapAn.xml");
                XmlDocument doc = new XmlDocument();
                doc.Load(ofd.FileName);
                XmlNodeList nodelist = doc.DocumentElement.ChildNodes;
                foreach (XmlNode child in nodelist)
                {
                    stt++;
                    Combo_De.Items.Add("Đề " + child.Attributes["ma_de"].Value.ToString());
                }
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        bool Check()
        {
            if (Combo_De.Text != "" && Text_Hoten.Text != "" && Text_Hoten.Text.Length > 0
                && Text_MSSV.Text != "" && Text_MSSV.Text.Length > 0)
                return true;
            return false;
        }
        private void Button_DN_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                bool_close = true;
                Hoten = Text_Hoten.Text;
                MSSV = Text_MSSV.Text;
                Ma_De = Combo_De.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "Báo lỗi");
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bool_close == false)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
      
    }
}
