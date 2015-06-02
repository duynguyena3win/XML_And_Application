namespace Bai_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.Text_VeSo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vé số của bạn";
            // 
            // Text_VeSo
            // 
            this.Text_VeSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_VeSo.Location = new System.Drawing.Point(155, 27);
            this.Text_VeSo.Name = "Text_VeSo";
            this.Text_VeSo.Size = new System.Drawing.Size(117, 27);
            this.Text_VeSo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(98, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "DÒ SỐ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text_Result
            // 
            this.Text_Result.Enabled = false;
            this.Text_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Result.Location = new System.Drawing.Point(30, 148);
            this.Text_Result.Multiline = true;
            this.Text_Result.Name = "Text_Result";
            this.Text_Result.Size = new System.Drawing.Size(227, 94);
            this.Text_Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Text_Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_VeSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XỔ SỐ KIẾN THIẾT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_VeSo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Text_Result;
    }
}

