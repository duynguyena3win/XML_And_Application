namespace Don_Xin_Phep
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Combo_LyDo = new System.Windows.Forms.ComboBox();
            this.Text_Ngay = new System.Windows.Forms.TextBox();
            this.Text_CMND = new System.Windows.Forms.TextBox();
            this.Text_DonVi = new System.Windows.Forms.TextBox();
            this.Text_Hoten = new System.Windows.Forms.TextBox();
            this.DateTime_Start_Day = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Button_Next);
            this.panel1.Controls.Add(this.Button_Previous);
            this.panel1.Controls.Add(this.Combo_LyDo);
            this.panel1.Controls.Add(this.Text_Ngay);
            this.panel1.Controls.Add(this.Text_CMND);
            this.panel1.Controls.Add(this.Text_DonVi);
            this.panel1.Controls.Add(this.Text_Hoten);
            this.panel1.Controls.Add(this.DateTime_Start_Day);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 241);
            this.panel1.TabIndex = 0;
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(497, 187);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(92, 39);
            this.Button_Next.TabIndex = 6;
            this.Button_Next.Text = "> > >";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Button_Previous
            // 
            this.Button_Previous.Location = new System.Drawing.Point(383, 187);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(92, 39);
            this.Button_Previous.TabIndex = 6;
            this.Button_Previous.Text = "< < <";
            this.Button_Previous.UseVisualStyleBackColor = true;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Combo_LyDo
            // 
            this.Combo_LyDo.FormattingEnabled = true;
            this.Combo_LyDo.Location = new System.Drawing.Point(138, 146);
            this.Combo_LyDo.Name = "Combo_LyDo";
            this.Combo_LyDo.Size = new System.Drawing.Size(242, 24);
            this.Combo_LyDo.TabIndex = 5;
            // 
            // Text_Ngay
            // 
            this.Text_Ngay.Location = new System.Drawing.Point(463, 65);
            this.Text_Ngay.Name = "Text_Ngay";
            this.Text_Ngay.Size = new System.Drawing.Size(50, 23);
            this.Text_Ngay.TabIndex = 4;
            // 
            // Text_CMND
            // 
            this.Text_CMND.Enabled = false;
            this.Text_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CMND.Location = new System.Drawing.Point(463, 28);
            this.Text_CMND.Name = "Text_CMND";
            this.Text_CMND.Size = new System.Drawing.Size(118, 23);
            this.Text_CMND.TabIndex = 4;
            // 
            // Text_DonVi
            // 
            this.Text_DonVi.Enabled = false;
            this.Text_DonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_DonVi.Location = new System.Drawing.Point(97, 68);
            this.Text_DonVi.Name = "Text_DonVi";
            this.Text_DonVi.Size = new System.Drawing.Size(283, 23);
            this.Text_DonVi.TabIndex = 4;
            // 
            // Text_Hoten
            // 
            this.Text_Hoten.Enabled = false;
            this.Text_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Hoten.Location = new System.Drawing.Point(97, 28);
            this.Text_Hoten.Name = "Text_Hoten";
            this.Text_Hoten.Size = new System.Drawing.Size(283, 23);
            this.Text_Hoten.TabIndex = 0;
            // 
            // DateTime_Start_Day
            // 
            this.DateTime_Start_Day.Location = new System.Drawing.Point(136, 108);
            this.DateTime_Start_Day.Name = "DateTime_Start_Day";
            this.DateTime_Start_Day.Size = new System.Drawing.Size(244, 23);
            this.DateTime_Start_Day.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh sách lý do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ĐƠN XIN PHÉP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Ngay;
        private System.Windows.Forms.TextBox Text_CMND;
        private System.Windows.Forms.TextBox Text_DonVi;
        private System.Windows.Forms.TextBox Text_Hoten;
        private System.Windows.Forms.DateTimePicker DateTime_Start_Day;
        private System.Windows.Forms.ComboBox Combo_LyDo;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_Previous;
    }
}

