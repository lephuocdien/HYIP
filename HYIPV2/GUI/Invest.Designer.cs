namespace GUI
{
    partial class Invest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_monitor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_timejoin = new System.Windows.Forms.DateTimePicker();
            this.textBox_rcb = new System.Windows.Forms.TextBox();
            this.textBox_dep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dep = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(79, 202);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(200, 21);
            this.comboBox_status.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "STATUS";
            // 
            // comboBox_monitor
            // 
            this.comboBox_monitor.FormattingEnabled = true;
            this.comboBox_monitor.Location = new System.Drawing.Point(79, 118);
            this.comboBox_monitor.Name = "comboBox_monitor";
            this.comboBox_monitor.Size = new System.Drawing.Size(200, 21);
            this.comboBox_monitor.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Monitor";
            // 
            // dateTimePicker_timejoin
            // 
            this.dateTimePicker_timejoin.Location = new System.Drawing.Point(79, 74);
            this.dateTimePicker_timejoin.Name = "dateTimePicker_timejoin";
            this.dateTimePicker_timejoin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_timejoin.TabIndex = 15;
            // 
            // textBox_rcb
            // 
            this.textBox_rcb.Location = new System.Drawing.Point(79, 161);
            this.textBox_rcb.Name = "textBox_rcb";
            this.textBox_rcb.Size = new System.Drawing.Size(200, 20);
            this.textBox_rcb.TabIndex = 18;
            this.textBox_rcb.Leave += new System.EventHandler(this.textBox_rcb_Leave);
            // 
            // textBox_dep
            // 
            this.textBox_dep.Location = new System.Drawing.Point(79, 40);
            this.textBox_dep.Name = "textBox_dep";
            this.textBox_dep.Size = new System.Drawing.Size(200, 20);
            this.textBox_dep.TabIndex = 12;
            this.textBox_dep.Leave += new System.EventHandler(this.textBox_dep_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "RCB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // label_dep
            // 
            this.label_dep.AutoSize = true;
            this.label_dep.Location = new System.Drawing.Point(6, 47);
            this.label_dep.Name = "label_dep";
            this.label_dep.Size = new System.Drawing.Size(43, 13);
            this.label_dep.TabIndex = 9;
            this.label_dep.Text = "Deposit";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(79, 8);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 20);
            this.textBox_name.TabIndex = 11;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Invest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_monitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_timejoin);
            this.Controls.Add(this.textBox_rcb);
            this.Controls.Add(this.textBox_dep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_dep);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Name = "Invest";
            this.Text = "Invest";
            this.Load += new System.EventHandler(this.Invest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_monitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_timejoin;
        private System.Windows.Forms.TextBox textBox_rcb;
        private System.Windows.Forms.TextBox textBox_dep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_dep;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}