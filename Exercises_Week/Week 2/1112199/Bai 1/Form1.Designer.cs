namespace Bai_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Text_A = new System.Windows.Forms.TextBox();
            this.Text_C = new System.Windows.Forms.TextBox();
            this.Text_B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Dir = new System.Windows.Forms.TextBox();
            this.Button_Cal = new System.Windows.Forms.Button();
            this.Text_Out = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_X1 = new System.Windows.Forms.TextBox();
            this.Text_X2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_A
            // 
            this.Text_A.Location = new System.Drawing.Point(45, 76);
            this.Text_A.Name = "Text_A";
            this.Text_A.Size = new System.Drawing.Size(46, 20);
            this.Text_A.TabIndex = 2;
            // 
            // Text_C
            // 
            this.Text_C.Location = new System.Drawing.Point(280, 76);
            this.Text_C.Name = "Text_C";
            this.Text_C.Size = new System.Drawing.Size(46, 20);
            this.Text_C.TabIndex = 3;
            // 
            // Text_B
            // 
            this.Text_B.Location = new System.Drawing.Point(164, 76);
            this.Text_B.Name = "Text_B";
            this.Text_B.Size = new System.Drawing.Size(46, 20);
            this.Text_B.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "c =";
            // 
            // Text_Dir
            // 
            this.Text_Dir.Location = new System.Drawing.Point(9, 8);
            this.Text_Dir.Name = "Text_Dir";
            this.Text_Dir.Size = new System.Drawing.Size(378, 20);
            this.Text_Dir.TabIndex = 8;
            // 
            // Button_Cal
            // 
            this.Button_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cal.Location = new System.Drawing.Point(122, 115);
            this.Button_Cal.Name = "Button_Cal";
            this.Button_Cal.Size = new System.Drawing.Size(125, 42);
            this.Button_Cal.TabIndex = 9;
            this.Button_Cal.Text = "Tính Toán";
            this.Button_Cal.UseVisualStyleBackColor = true;
            this.Button_Cal.Click += new System.EventHandler(this.Button_Cal_Click);
            // 
            // Text_Out
            // 
            this.Text_Out.Location = new System.Drawing.Point(9, 236);
            this.Text_Out.Name = "Text_Out";
            this.Text_Out.Size = new System.Drawing.Size(378, 20);
            this.Text_Out.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Write Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "x2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "x1 =";
            // 
            // Text_X1
            // 
            this.Text_X1.Location = new System.Drawing.Point(88, 178);
            this.Text_X1.Name = "Text_X1";
            this.Text_X1.Size = new System.Drawing.Size(80, 20);
            this.Text_X1.TabIndex = 13;
            // 
            // Text_X2
            // 
            this.Text_X2.Location = new System.Drawing.Point(231, 178);
            this.Text_X2.Name = "Text_X2";
            this.Text_X2.Size = new System.Drawing.Size(84, 20);
            this.Text_X2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 278);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Text_X1);
            this.Controls.Add(this.Text_X2);
            this.Controls.Add(this.Text_Out);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button_Cal);
            this.Controls.Add(this.Text_Dir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_B);
            this.Controls.Add(this.Text_C);
            this.Controls.Add(this.Text_A);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Text_A;
        private System.Windows.Forms.TextBox Text_C;
        private System.Windows.Forms.TextBox Text_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Dir;
        private System.Windows.Forms.Button Button_Cal;
        private System.Windows.Forms.TextBox Text_Out;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_X1;
        private System.Windows.Forms.TextBox Text_X2;
    }
}

