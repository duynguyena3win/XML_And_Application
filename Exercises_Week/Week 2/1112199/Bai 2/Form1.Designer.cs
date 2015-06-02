namespace Bai_2
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
            this.Text_Dir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Out = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text_Dir
            // 
            this.Text_Dir.Location = new System.Drawing.Point(19, 14);
            this.Text_Dir.Name = "Text_Dir";
            this.Text_Dir.Size = new System.Drawing.Size(374, 20);
            this.Text_Dir.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_Out
            // 
            this.Text_Out.Location = new System.Drawing.Point(19, 190);
            this.Text_Out.Name = "Text_Out";
            this.Text_Out.Size = new System.Drawing.Size(374, 20);
            this.Text_Out.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Save Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Result";
            // 
            // Text_Result
            // 
            this.Text_Result.Location = new System.Drawing.Point(107, 132);
            this.Text_Result.Name = "Text_Result";
            this.Text_Result.Size = new System.Drawing.Size(300, 20);
            this.Text_Result.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 235);
            this.Controls.Add(this.Text_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Out);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_Dir);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Dir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Text_Out;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Result;

    }
}

