namespace GUI
{
    partial class AddWebTracking
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_withdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_deposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_addrress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Withdraw";
            // 
            // textBox_withdraw
            // 
            this.textBox_withdraw.Location = new System.Drawing.Point(82, 89);
            this.textBox_withdraw.Name = "textBox_withdraw";
            this.textBox_withdraw.Size = new System.Drawing.Size(171, 20);
            this.textBox_withdraw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deposit";
            // 
            // textBox_deposit
            // 
            this.textBox_deposit.Location = new System.Drawing.Point(82, 49);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(171, 20);
            this.textBox_deposit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address";
            // 
            // textBox_addrress
            // 
            this.textBox_addrress.Location = new System.Drawing.Point(82, 12);
            this.textBox_addrress.Name = "textBox_addrress";
            this.textBox_addrress.Size = new System.Drawing.Size(171, 20);
            this.textBox_addrress.TabIndex = 1;
            // 
            // AddWebTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 166);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_withdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_deposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_addrress);
            this.Name = "AddWebTracking";
            this.Text = "AddWebTracking";
            this.Load += new System.EventHandler(this.AddWebTracking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_withdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_addrress;
    }
}