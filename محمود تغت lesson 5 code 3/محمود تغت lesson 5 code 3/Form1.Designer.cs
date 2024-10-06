namespace محمود_تغت_lesson_5_code_3
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
            this.button2 = new System.Windows.Forms.Button();
            this.but_dow = new System.Windows.Forms.Button();
            this.but_sid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "التحرك يمين";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "التحرك اسفل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_dow
            // 
            this.but_dow.Location = new System.Drawing.Point(12, 196);
            this.but_dow.Name = "but_dow";
            this.but_dow.Size = new System.Drawing.Size(75, 23);
            this.but_dow.TabIndex = 2;
            this.but_dow.Text = "v";
            this.but_dow.UseVisualStyleBackColor = true;
            // 
            // but_sid
            // 
            this.but_sid.Location = new System.Drawing.Point(271, 12);
            this.but_sid.Name = "but_sid";
            this.but_sid.Size = new System.Drawing.Size(75, 23);
            this.but_sid.TabIndex = 3;
            this.but_sid.Text = ">";
            this.but_sid.UseVisualStyleBackColor = true;
            this.but_sid.Click += new System.EventHandler(this.but_sid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 398);
            this.Controls.Add(this.but_sid);
            this.Controls.Add(this.but_dow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_dow;
        private System.Windows.Forms.Button but_sid;
    }
}

