namespace Tu_Ren_Luyen_Trac_Nghiem
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
            this.Textbox_Cau = new System.Windows.Forms.TextBox();
            this.Radio_A = new System.Windows.Forms.RadioButton();
            this.Radio_C = new System.Windows.Forms.RadioButton();
            this.Radio_B = new System.Windows.Forms.RadioButton();
            this.Radio_D = new System.Windows.Forms.RadioButton();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Button_Finish = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Label_Hoten = new System.Windows.Forms.Label();
            this.Label_MSSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Textbox_Cau
            // 
            this.Textbox_Cau.Enabled = false;
            this.Textbox_Cau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Cau.Location = new System.Drawing.Point(19, 60);
            this.Textbox_Cau.Multiline = true;
            this.Textbox_Cau.Name = "Textbox_Cau";
            this.Textbox_Cau.Size = new System.Drawing.Size(608, 108);
            this.Textbox_Cau.TabIndex = 0;
            // 
            // Radio_A
            // 
            this.Radio_A.AutoSize = true;
            this.Radio_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_A.Location = new System.Drawing.Point(171, 184);
            this.Radio_A.Name = "Radio_A";
            this.Radio_A.Size = new System.Drawing.Size(85, 21);
            this.Radio_A.TabIndex = 0;
            this.Radio_A.TabStop = true;
            this.Radio_A.Text = "Đáp án A";
            this.Radio_A.UseVisualStyleBackColor = true;
            // 
            // Radio_C
            // 
            this.Radio_C.AutoSize = true;
            this.Radio_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_C.Location = new System.Drawing.Point(171, 215);
            this.Radio_C.Name = "Radio_C";
            this.Radio_C.Size = new System.Drawing.Size(85, 21);
            this.Radio_C.TabIndex = 2;
            this.Radio_C.TabStop = true;
            this.Radio_C.Text = "Đáp án C";
            this.Radio_C.UseVisualStyleBackColor = true;
            // 
            // Radio_B
            // 
            this.Radio_B.AutoSize = true;
            this.Radio_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_B.Location = new System.Drawing.Point(390, 184);
            this.Radio_B.Name = "Radio_B";
            this.Radio_B.Size = new System.Drawing.Size(85, 21);
            this.Radio_B.TabIndex = 1;
            this.Radio_B.TabStop = true;
            this.Radio_B.Text = "Đáp án B";
            this.Radio_B.UseVisualStyleBackColor = true;
            // 
            // Radio_D
            // 
            this.Radio_D.AutoSize = true;
            this.Radio_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_D.Location = new System.Drawing.Point(390, 215);
            this.Radio_D.Name = "Radio_D";
            this.Radio_D.Size = new System.Drawing.Size(86, 21);
            this.Radio_D.TabIndex = 3;
            this.Radio_D.TabStop = true;
            this.Radio_D.Text = "Đáp án D";
            this.Radio_D.UseVisualStyleBackColor = true;
            // 
            // Button_Previous
            // 
            this.Button_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Previous.Location = new System.Drawing.Point(19, 246);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(97, 32);
            this.Button_Previous.TabIndex = 4;
            this.Button_Previous.Text = "<<<";
            this.Button_Previous.UseVisualStyleBackColor = true;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Button_Finish
            // 
            this.Button_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Finish.Location = new System.Drawing.Point(274, 246);
            this.Button_Finish.Name = "Button_Finish";
            this.Button_Finish.Size = new System.Drawing.Size(97, 32);
            this.Button_Finish.TabIndex = 6;
            this.Button_Finish.Text = "Nộp Bài";
            this.Button_Finish.UseVisualStyleBackColor = true;
            this.Button_Finish.Click += new System.EventHandler(this.Button_Finish_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Next.Location = new System.Drawing.Point(529, 245);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(97, 32);
            this.Button_Next.TabIndex = 5;
            this.Button_Next.Text = ">>>";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Label_Hoten
            // 
            this.Label_Hoten.AutoSize = true;
            this.Label_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hoten.Location = new System.Drawing.Point(16, 20);
            this.Label_Hoten.Name = "Label_Hoten";
            this.Label_Hoten.Size = new System.Drawing.Size(46, 18);
            this.Label_Hoten.TabIndex = 6;
            this.Label_Hoten.Text = "label1";
            // 
            // Label_MSSV
            // 
            this.Label_MSSV.AutoSize = true;
            this.Label_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MSSV.Location = new System.Drawing.Point(430, 20);
            this.Label_MSSV.Name = "Label_MSSV";
            this.Label_MSSV.Size = new System.Drawing.Size(46, 18);
            this.Label_MSSV.TabIndex = 6;
            this.Label_MSSV.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(645, 295);
            this.Controls.Add(this.Label_MSSV);
            this.Controls.Add(this.Label_Hoten);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Button_Finish);
            this.Controls.Add(this.Button_Previous);
            this.Controls.Add(this.Radio_D);
            this.Controls.Add(this.Radio_B);
            this.Controls.Add(this.Radio_C);
            this.Controls.Add(this.Radio_A);
            this.Controls.Add(this.Textbox_Cau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RÈN LUYỆN TRẮC NGHIỆM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_Cau;
        private System.Windows.Forms.RadioButton Radio_A;
        private System.Windows.Forms.RadioButton Radio_C;
        private System.Windows.Forms.RadioButton Radio_B;
        private System.Windows.Forms.RadioButton Radio_D;
        private System.Windows.Forms.Button Button_Previous;
        private System.Windows.Forms.Button Button_Finish;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Label Label_Hoten;
        private System.Windows.Forms.Label Label_MSSV;
    }
}

