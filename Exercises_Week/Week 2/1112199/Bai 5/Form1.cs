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
namespace Bai_5
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            Mo_Bang_Ty_Gia();
        }

        void Mo_Bang_Ty_Gia()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML File|*.xml";
            ofd.Title = "MỞ BẢNG TỶ GIÁ";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Load(ofd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Combo_NgTe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NgTe = Combo_NgTe.Text[0].ToString() + Combo_NgTe.Text[1].ToString() + Combo_NgTe.Text[2].ToString();
            XmlNode Node = (XmlElement)doc.SelectSingleNode("/TyGia/" + NgTe);
            Text_TM.Text = Node.Attributes["mtm"].Value;
            Text_CK.Text = Node.Attributes["mck"].Value;
            Text_Ban.Text = Node.Attributes["ban"].Value;
            Label_NgTe.Text = NgTe;
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            Double SoTien = Convert.ToDouble(Text_SoTien.Text) * Convert.ToDouble(Text_TM.Text);
            Text_TM_VND.Text = SoTien.ToString();

            SoTien = Convert.ToDouble(Text_SoTien.Text) * Convert.ToDouble(Text_CK.Text);
            Text_CK_VND.Text = SoTien.ToString();

            SoTien = Convert.ToDouble(Text_SoTien.Text) * Convert.ToDouble(Text_Ban.Text);
            Text_Ban_VND.Text = SoTien.ToString();
        }
    }
}
