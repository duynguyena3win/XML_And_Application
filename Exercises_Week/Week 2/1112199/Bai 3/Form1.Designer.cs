namespace Bai_3
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
            this.Button_Read = new System.Windows.Forms.Button();
            this.Button_Save_2 = new System.Windows.Forms.Button();
            this.Button_Save_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Read
            // 
            this.Button_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Read.Location = new System.Drawing.Point(52, 36);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(161, 40);
            this.Button_Read.TabIndex = 0;
            this.Button_Read.Text = "Đọc dữ liệu Ma Trận 1";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // Button_Save_2
            // 
            this.Button_Save_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save_2.Location = new System.Drawing.Point(52, 121);
            this.Button_Save_2.Name = "Button_Save_2";
            this.Button_Save_2.Size = new System.Drawing.Size(161, 40);
            this.Button_Save_2.TabIndex = 1;
            this.Button_Save_2.Text = "Lưu dữ liệu Ma Trận 2";
            this.Button_Save_2.UseVisualStyleBackColor = true;
            this.Button_Save_2.Click += new System.EventHandler(this.Button_Save_2_Click);
            // 
            // Button_Save_3
            // 
            this.Button_Save_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save_3.Location = new System.Drawing.Point(52, 206);
            this.Button_Save_3.Name = "Button_Save_3";
            this.Button_Save_3.Size = new System.Drawing.Size(161, 40);
            this.Button_Save_3.TabIndex = 2;
            this.Button_Save_3.Text = "Lưu dữ liệu Ma Trận 3";
            this.Button_Save_3.UseVisualStyleBackColor = true;
            this.Button_Save_3.Click += new System.EventHandler(this.Button_Save_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 292);
            this.Controls.Add(this.Button_Save_3);
            this.Controls.Add(this.Button_Save_2);
            this.Controls.Add(this.Button_Read);
            this.Name = "Form1";
            this.Text = "MA TRẬN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.Button Button_Save_2;
        private System.Windows.Forms.Button Button_Save_3;
    }
}

