namespace GUI
{
    partial class Withdraw
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_redep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rcb_re = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_withdraw = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_redep);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_rcb_re);
            this.panel2.Location = new System.Drawing.Point(241, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 131);
            this.panel2.TabIndex = 6;
            // 
            // btn_redep
            // 
            this.btn_redep.Location = new System.Drawing.Point(47, 108);
            this.btn_redep.Name = "btn_redep";
            this.btn_redep.Size = new System.Drawing.Size(130, 23);
            this.btn_redep.TabIndex = 1;
            this.btn_redep.Text = "Re_Deposit";
            this.btn_redep.UseVisualStyleBackColor = true;
            this.btn_redep.Click += new System.EventHandler(this.btn_redep_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "RCB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // textBox_rcb_re
            // 
            this.textBox_rcb_re.Location = new System.Drawing.Point(77, 67);
            this.textBox_rcb_re.Name = "textBox_rcb_re";
            this.textBox_rcb_re.Size = new System.Drawing.Size(100, 20);
            this.textBox_rcb_re.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_withdraw);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 131);
            this.panel1.TabIndex = 5;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(106, 7);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(103, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount Withdraw :";
            // 
            // textBox_withdraw
            // 
            this.textBox_withdraw.Location = new System.Drawing.Point(162, 67);
            this.textBox_withdraw.Name = "textBox_withdraw";
            this.textBox_withdraw.Size = new System.Drawing.Size(47, 20);
            this.textBox_withdraw.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(162, 37);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(47, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 152);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_redep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_rcb_re;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_withdraw;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
    }
}