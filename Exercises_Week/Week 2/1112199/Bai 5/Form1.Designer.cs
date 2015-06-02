namespace Bai_5
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
            this.Text_SoTien = new System.Windows.Forms.TextBox();
            this.Combo_NgTe = new System.Windows.Forms.ComboBox();
            this.Button_Change = new System.Windows.Forms.Button();
            this.Text_CK = new System.Windows.Forms.TextBox();
            this.Text_TM = new System.Windows.Forms.TextBox();
            this.Text_Ban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_NgTe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Text_Ban_VND = new System.Windows.Forms.TextBox();
            this.Text_TM_VND = new System.Windows.Forms.TextBox();
            this.Text_CK_VND = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_SoTien
            // 
            this.Text_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_SoTien.Location = new System.Drawing.Point(122, 200);
            this.Text_SoTien.Name = "Text_SoTien";
            this.Text_SoTien.Size = new System.Drawing.Size(181, 27);
            this.Text_SoTien.TabIndex = 2;
            this.Text_SoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Combo_NgTe
            // 
            this.Combo_NgTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_NgTe.FormattingEnabled = true;
            this.Combo_NgTe.Items.AddRange(new object[] {
            "USD - US DOLLAR",
            "EUR - EURO",
            "CAD - CANADIAN DOLLAR",
            "THB - THAI BAHT",
            "JPY - JAPANESE YEN",
            "GBP - BRITISH POUND"});
            this.Combo_NgTe.Location = new System.Drawing.Point(46, 20);
            this.Combo_NgTe.Name = "Combo_NgTe";
            this.Combo_NgTe.Size = new System.Drawing.Size(245, 26);
            this.Combo_NgTe.TabIndex = 4;
            this.Combo_NgTe.SelectedIndexChanged += new System.EventHandler(this.Combo_NgTe_SelectedIndexChanged);
            // 
            // Button_Change
            // 
            this.Button_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Change.Location = new System.Drawing.Point(144, 242);
            this.Button_Change.Name = "Button_Change";
            this.Button_Change.Size = new System.Drawing.Size(105, 41);
            this.Button_Change.TabIndex = 5;
            this.Button_Change.Text = "ĐỔI TIỀN";
            this.Button_Change.UseVisualStyleBackColor = true;
            this.Button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // Text_CK
            // 
            this.Text_CK.Enabled = false;
            this.Text_CK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CK.Location = new System.Drawing.Point(147, 94);
            this.Text_CK.Name = "Text_CK";
            this.Text_CK.Size = new System.Drawing.Size(131, 21);
            this.Text_CK.TabIndex = 7;
            this.Text_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_TM
            // 
            this.Text_TM.Enabled = false;
            this.Text_TM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TM.Location = new System.Drawing.Point(147, 58);
            this.Text_TM.Name = "Text_TM";
            this.Text_TM.Size = new System.Drawing.Size(131, 21);
            this.Text_TM.TabIndex = 8;
            this.Text_TM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_Ban
            // 
            this.Text_Ban.Enabled = false;
            this.Text_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Ban.Location = new System.Drawing.Point(147, 130);
            this.Text_Ban.Name = "Text_Ban";
            this.Text_Ban.Size = new System.Drawing.Size(131, 21);
            this.Text_Ban.TabIndex = 9;
            this.Text_Ban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mua tiền mặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mua chuyển khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số Ngoại Tệ";
            // 
            // Label_NgTe
            // 
            this.Label_NgTe.AutoSize = true;
            this.Label_NgTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NgTe.Location = new System.Drawing.Point(320, 202);
            this.Label_NgTe.Name = "Label_NgTe";
            this.Label_NgTe.Size = new System.Drawing.Size(60, 22);
            this.Label_NgTe.TabIndex = 15;
            this.Label_NgTe.Text = "Ng Tệ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Text_Ban);
            this.groupBox1.Controls.Add(this.Text_TM);
            this.groupBox1.Controls.Add(this.Text_CK);
            this.groupBox1.Controls.Add(this.Combo_NgTe);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN TỶ GIÁ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Text_Ban_VND);
            this.groupBox2.Controls.Add(this.Text_TM_VND);
            this.groupBox2.Controls.Add(this.Text_CK_VND);
            this.groupBox2.Location = new System.Drawing.Point(8, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 121);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KẾT QUẢ ĐỔI TIỀN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "VND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mua chuyển khoản";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Mua tiền mặt";
            // 
            // Text_Ban_VND
            // 
            this.Text_Ban_VND.Enabled = false;
            this.Text_Ban_VND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Ban_VND.Location = new System.Drawing.Point(147, 92);
            this.Text_Ban_VND.Name = "Text_Ban_VND";
            this.Text_Ban_VND.Size = new System.Drawing.Size(179, 21);
            this.Text_Ban_VND.TabIndex = 9;
            this.Text_Ban_VND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_TM_VND
            // 
            this.Text_TM_VND.Enabled = false;
            this.Text_TM_VND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TM_VND.Location = new System.Drawing.Point(147, 20);
            this.Text_TM_VND.Name = "Text_TM_VND";
            this.Text_TM_VND.Size = new System.Drawing.Size(179, 21);
            this.Text_TM_VND.TabIndex = 8;
            this.Text_TM_VND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_CK_VND
            // 
            this.Text_CK_VND.Enabled = false;
            this.Text_CK_VND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CK_VND.Location = new System.Drawing.Point(147, 57);
            this.Text_CK_VND.Name = "Text_CK_VND";
            this.Text_CK_VND.Size = new System.Drawing.Size(179, 21);
            this.Text_CK_VND.TabIndex = 7;
            this.Text_CK_VND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label_NgTe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button_Change);
            this.Controls.Add(this.Text_SoTien);
            this.Name = "Form1";
            this.Text = "TÍNH TIỀN VIỆT NAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_SoTien;
        private System.Windows.Forms.ComboBox Combo_NgTe;
        private System.Windows.Forms.Button Button_Change;
        private System.Windows.Forms.TextBox Text_CK;
        private System.Windows.Forms.TextBox Text_TM;
        private System.Windows.Forms.TextBox Text_Ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_NgTe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Text_Ban_VND;
        private System.Windows.Forms.TextBox Text_TM_VND;
        private System.Windows.Forms.TextBox Text_CK_VND;
    }
}

