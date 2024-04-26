namespace Paint
{
    partial class Save
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
            this.save1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okBut2 = new System.Windows.Forms.Button();
            this.canBut3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save1
            // 
            this.save1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save1.Location = new System.Drawing.Point(12, 12);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(81, 24);
            this.save1.TabIndex = 0;
            this.save1.Text = "Сохранить";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя файла";
            // 
            // okBut2
            // 
            this.okBut2.Location = new System.Drawing.Point(65, 85);
            this.okBut2.Name = "okBut2";
            this.okBut2.Size = new System.Drawing.Size(81, 23);
            this.okBut2.TabIndex = 4;
            this.okBut2.Text = "OK";
            this.okBut2.UseVisualStyleBackColor = true;
            this.okBut2.Click += new System.EventHandler(this.okBut2_Click);
            // 
            // canBut3
            // 
            this.canBut3.Location = new System.Drawing.Point(182, 85);
            this.canBut3.Name = "canBut3";
            this.canBut3.Size = new System.Drawing.Size(75, 23);
            this.canBut3.TabIndex = 5;
            this.canBut3.Text = "Выйти";
            this.canBut3.UseVisualStyleBackColor = true;
            this.canBut3.Click += new System.EventHandler(this.canBut3_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 126);
            this.Controls.Add(this.canBut3);
            this.Controls.Add(this.okBut2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save1);
            this.Name = "Save";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBut2;
        private System.Windows.Forms.Button canBut3;
    }
}