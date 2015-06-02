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

namespace Tu_Ren_Luyen_Trac_Nghiem
{
    public partial class Form1 : Form
    {
        List<Cauhoi> Debai;
        DapAn Ketqua;

        DangNhap DN;
        int So_cau;
        int Current_Ques;

        string Example = " Câu  ms1112199_stt : \r\n  ms1112199_Cauhoi  \r\n Đáp án: \r\n A. ms1112199_a \r\t\t B. ms1112199_b \r\n C. ms1112199_c \r\t\t D. ms1112199_d ";
        public Form1()
        {
            InitializeComponent();
            Init_Radio();
            Debai = new List<Cauhoi>();
            So_cau = 0;
            
        }

        void Init_Radio()
        {
            Radio_A.Checked = true;
            Radio_C.Checked = Radio_B.Checked = Radio_D.Checked = false;
        }

        string Create_Question(string example)
        {
            example = example.Replace("ms1112199_stt", (Current_Ques + 1).ToString());
            example = example.Replace("ms1112199_a", Debai[Current_Ques].a);
            example = example.Replace("ms1112199_b", Debai[Current_Ques].b);
            example = example.Replace("ms1112199_c", Debai[Current_Ques].c);
            example = example.Replace("ms1112199_d", Debai[Current_Ques].d);
            example = example.Replace("ms1112199_Cauhoi", Debai[Current_Ques].Cau_hoi);
            return example;
        }

        void Load_DS_CauHoi()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(DN.Path_XML_File);
            XmlNodeList nodelist = doc.DocumentElement.ChildNodes;
            foreach (XmlNode child in nodelist)
            {
                if (DN.Ma_De.IndexOf(child.Attributes["ma_de"].Value) > 0)
                {
                    foreach (XmlNode cau in child)
                    {
                        Cauhoi CH = new Cauhoi();
                        So_cau++;
                        CH.Cau_hoi = cau.Attributes["cau_hoi"].Value;
                        foreach (XmlNode dapan in cau)
                        {
                            CH.a = dapan.Attributes["a"].Value;
                            CH.b = dapan.Attributes["b"].Value;
                            CH.c = dapan.Attributes["c"].Value;
                            CH.d = dapan.Attributes["d"].Value;
                        }
                        Debai.Add(CH);
                    }
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DN = new DangNhap();
            if (DN.DialogResult != System.Windows.Forms.DialogResult.Cancel)
            {
                if (DN.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Label_Hoten.Text = "Họ và tên: " + DN.Hoten;
                    Label_MSSV.Text = "MSSV: " + DN.MSSV;
                    Load_DS_CauHoi();
                    Ketqua = new DapAn(DN.Path_XML_DapAn, DN.Ma_De);
                    Textbox_Cau.Text = Create_Question(Example);
                }
                else
                {
                    DN.Dispose();
                    this.Dispose();
                }
            }
            else
            {
                DN.Dispose();
                this.Dispose();
            }
        }

        void Again_Answer(string x)
        {
            switch (x)
            {
                case "a":
                    Radio_A.Checked = true;
                    break;
                case "b":
                    Radio_B.Checked = true;
                    break;
                case "c":
                    Radio_C.Checked = true;
                    break;
                case "d":
                    Radio_D.Checked = true;
                    break;
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (++Current_Ques > So_cau - 1)
                Current_Ques = 0;

            Save_Current(Current_Ques - 1);

            Again_Answer(Ketqua.DapAn_NgDung[Current_Ques]);
            
            Textbox_Cau.Text = Create_Question(Example);
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (--Current_Ques < 0)
                Current_Ques = So_cau - 1;

            Save_Current(Current_Ques + 1);

            Again_Answer(Ketqua.DapAn_NgDung[Current_Ques]);

            Textbox_Cau.Text = Create_Question(Example);
        }

        void Save_Current(int cur)
        {
            if (cur < 0)
                cur = So_cau - 1;
            if (cur > So_cau - 1)
                cur = 0;
            Ketqua.DapAn_NgDung[cur] = String_Answer();
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

        private void Button_Finish_Click(object sender, EventArgs e)
        {
            Ketqua.Cal_Score();
            MessageBox.Show("Số điểm bạn đạt được là: " + Ketqua.Score,"Thông Báo");
            DN.Dispose();
            this.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
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
    }

    public class DapAn
    {
        public List<string> DapAn_NgDung;
        public List<string> Dapan_DeBai;
        public float Score = 0;
        public DapAn(string Path, string Ma_de)
        {
            Dapan_DeBai = new List<string>();
            DapAn_NgDung = new List<string>();
            Load_DapAn(Path, Ma_de);
        }

        void Load_DapAn(string Path, string Ma_de)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path);
            XmlNodeList nodelist = doc.DocumentElement.ChildNodes;
            foreach (XmlNode child in nodelist)
            {
                if (Ma_de.IndexOf(child.Attributes["ma_de"].Value) > 0)
                {
                    foreach (XmlNode cau in child)
                    {
                        Dapan_DeBai.Add(cau.Attributes["dap_an"].Value);
                        DapAn_NgDung.Add("a");
                    }
                    return;
                }
            }
        }

        public void Cal_Score()
        {
            float i_Score = 10/Dapan_DeBai.Count;
            for (int i = 0; i < Dapan_DeBai.Count; i++)
                if (DapAn_NgDung[i] == Dapan_DeBai[i])
                    Score += i_Score;
        }
    }
}
