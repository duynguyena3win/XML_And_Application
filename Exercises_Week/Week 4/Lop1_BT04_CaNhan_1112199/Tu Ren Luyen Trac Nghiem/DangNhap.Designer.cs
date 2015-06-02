namespace Tu_Ren_Luyen_Trac_Nghiem
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Hoten = new System.Windows.Forms.TextBox();
            this.Text_MSSV = new System.Windows.Forms.TextBox();
            this.Combo_De = new System.Windows.Forms.ComboBox();
            this.Button_DN = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bô đề :";
            // 
            // Text_Hoten
            // 
            this.Text_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Hoten.Location = new System.Drawing.Point(82, 20);
            this.Text_Hoten.Name = "Text_Hoten";
            this.Text_Hoten.Size = new System.Drawing.Size(158, 23);
            this.Text_Hoten.TabIndex = 0;
            // 
            // Text_MSSV
            // 
            this.Text_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_MSSV.Location = new System.Drawing.Point(82, 60);
            this.Text_MSSV.Name = "Text_MSSV";
            this.Text_MSSV.Size = new System.Drawing.Size(158, 23);
            this.Text_MSSV.TabIndex = 1;
            // 
            // Combo_De
            // 
            this.Combo_De.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_De.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_De.FormattingEnabled = true;
            this.Combo_De.Location = new System.Drawing.Point(82, 103);
            this.Combo_De.Name = "Combo_De";
            this.Combo_De.Size = new System.Drawing.Size(158, 24);
            this.Combo_De.TabIndex = 2;
            // 
            // Button_DN
            // 
            this.Button_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DN.Location = new System.Drawing.Point(31, 168);
            this.Button_DN.Name = "Button_DN";
            this.Button_DN.Size = new System.Drawing.Size(93, 39);
            this.Button_DN.TabIndex = 3;
            this.Button_DN.Text = "Đăng Nhập";
            this.Button_DN.UseVisualStyleBackColor = true;
            this.Button_DN.Click += new System.EventHandler(this.Button_DN_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(158, 168);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(93, 39);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Thoát";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_DN);
            this.Controls.Add(this.Combo_De);
            this.Controls.Add(this.Text_MSSV);
            this.Controls.Add(this.Text_Hoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Hoten;
        private System.Windows.Forms.TextBox Text_MSSV;
        private System.Windows.Forms.ComboBox Combo_De;
        private System.Windows.Forms.Button Button_DN;
        private System.Windows.Forms.Button Button_Exit;
    }
}