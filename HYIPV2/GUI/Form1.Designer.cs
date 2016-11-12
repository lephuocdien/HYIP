namespace GUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.textBox_heuritic_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_heu_total = new System.Windows.Forms.Label();
            this.dataGridView_heuristics = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_restore = new System.Windows.Forms.Button();
            this.button_bk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_profit = new System.Windows.Forms.GroupBox();
            this.label_with = new System.Windows.Forms.Label();
            this.label_dep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_tracking = new System.Windows.Forms.GroupBox();
            this.label_total_tracking = new System.Windows.Forms.Label();
            this.label_webtracking = new System.Windows.Forms.Label();
            this.button_trac = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_update_tracking = new System.Windows.Forms.Button();
            this.groupBox_invest = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_invest_scam = new System.Windows.Forms.RadioButton();
            this.radioButton_invest_paying = new System.Windows.Forms.RadioButton();
            this.radioButton_invest_all = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Percent = new Sample.DataGridViewProgressColumn();
            this.dailyprofit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updatestatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.with = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProgressColumn1 = new Sample.DataGridViewProgressColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_search.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_heuristics)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_profit.SuspendLayout();
            this.groupBox_tracking.SuspendLayout();
            this.groupBox_invest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_search);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_profit);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_tracking);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_invest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 488);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // groupBox_search
            // 
            this.groupBox_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_search.Controls.Add(this.textBox1);
            this.groupBox_search.Location = new System.Drawing.Point(1166, 4);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(77, 147);
            this.groupBox_search.TabIndex = 5;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_filter);
            this.groupBox3.Controls.Add(this.textBox_heuritic_value);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label_heu_total);
            this.groupBox3.Controls.Add(this.dataGridView_heuristics);
            this.groupBox3.Location = new System.Drawing.Point(930, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(7, 107);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(45, 23);
            this.button_filter.TabIndex = 6;
            this.button_filter.Text = "Filter";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // textBox_heuritic_value
            // 
            this.textBox_heuritic_value.Location = new System.Drawing.Point(6, 67);
            this.textBox_heuritic_value.Name = "textBox_heuritic_value";
            this.textBox_heuritic_value.Size = new System.Drawing.Size(46, 20);
            this.textBox_heuritic_value.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label_heu_total
            // 
            this.label_heu_total.AutoSize = true;
            this.label_heu_total.Location = new System.Drawing.Point(3, 16);
            this.label_heu_total.Name = "label_heu_total";
            this.label_heu_total.Size = new System.Drawing.Size(31, 13);
            this.label_heu_total.TabIndex = 1;
            this.label_heu_total.Text = "Total";
            // 
            // dataGridView_heuristics
            // 
            this.dataGridView_heuristics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_heuristics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_heuristics.Location = new System.Drawing.Point(58, 6);
            this.dataGridView_heuristics.Name = "dataGridView_heuristics";
            this.dataGridView_heuristics.RowHeadersVisible = false;
            this.dataGridView_heuristics.Size = new System.Drawing.Size(165, 135);
            this.dataGridView_heuristics.TabIndex = 0;
            this.dataGridView_heuristics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_heuristics_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_restore);
            this.groupBox2.Controls.Add(this.button_bk);
            this.groupBox2.Location = new System.Drawing.Point(805, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakup and Restore";
            // 
            // button_restore
            // 
            this.button_restore.Location = new System.Drawing.Point(19, 84);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(75, 23);
            this.button_restore.TabIndex = 1;
            this.button_restore.Text = "Restore";
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // button_bk
            // 
            this.button_bk.Location = new System.Drawing.Point(19, 43);
            this.button_bk.Name = "button_bk";
            this.button_bk.Size = new System.Drawing.Size(75, 23);
            this.button_bk.TabIndex = 0;
            this.button_bk.Text = "Bakup";
            this.button_bk.UseVisualStyleBackColor = true;
            this.button_bk.Click += new System.EventHandler(this.button_bk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(563, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Withdraw History";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 128);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // groupBox_profit
            // 
            this.groupBox_profit.Controls.Add(this.label_with);
            this.groupBox_profit.Controls.Add(this.label_dep);
            this.groupBox_profit.Controls.Add(this.label2);
            this.groupBox_profit.Controls.Add(this.label1);
            this.groupBox_profit.Location = new System.Drawing.Point(385, 4);
            this.groupBox_profit.Name = "groupBox_profit";
            this.groupBox_profit.Size = new System.Drawing.Size(172, 147);
            this.groupBox_profit.TabIndex = 2;
            this.groupBox_profit.TabStop = false;
            this.groupBox_profit.Text = "Profit";
            // 
            // label_with
            // 
            this.label_with.AutoSize = true;
            this.label_with.Location = new System.Drawing.Point(122, 94);
            this.label_with.Name = "label_with";
            this.label_with.Size = new System.Drawing.Size(35, 13);
            this.label_with.TabIndex = 1;
            this.label_with.Text = "label3";
            // 
            // label_dep
            // 
            this.label_dep.AutoSize = true;
            this.label_dep.Location = new System.Drawing.Point(122, 35);
            this.label_dep.Name = "label_dep";
            this.label_dep.Size = new System.Drawing.Size(35, 13);
            this.label_dep.TabIndex = 1;
            this.label_dep.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Withdraw :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Deposit :";
            // 
            // groupBox_tracking
            // 
            this.groupBox_tracking.Controls.Add(this.label_total_tracking);
            this.groupBox_tracking.Controls.Add(this.label_webtracking);
            this.groupBox_tracking.Controls.Add(this.button_trac);
            this.groupBox_tracking.Controls.Add(this.progressBar1);
            this.groupBox_tracking.Controls.Add(this.button_update_tracking);
            this.groupBox_tracking.Location = new System.Drawing.Point(173, 4);
            this.groupBox_tracking.Name = "groupBox_tracking";
            this.groupBox_tracking.Size = new System.Drawing.Size(206, 147);
            this.groupBox_tracking.TabIndex = 1;
            this.groupBox_tracking.TabStop = false;
            this.groupBox_tracking.Text = "Tracking";
            // 
            // label_total_tracking
            // 
            this.label_total_tracking.AutoSize = true;
            this.label_total_tracking.Location = new System.Drawing.Point(34, 31);
            this.label_total_tracking.Name = "label_total_tracking";
            this.label_total_tracking.Size = new System.Drawing.Size(113, 13);
            this.label_total_tracking.TabIndex = 6;
            this.label_total_tracking.Text = "Total web are tracking";
            this.label_total_tracking.Visible = false;
            // 
            // label_webtracking
            // 
            this.label_webtracking.AutoSize = true;
            this.label_webtracking.Location = new System.Drawing.Point(6, 94);
            this.label_webtracking.Name = "label_webtracking";
            this.label_webtracking.Size = new System.Drawing.Size(35, 13);
            this.label_webtracking.TabIndex = 5;
            this.label_webtracking.Text = "label3";
            this.label_webtracking.Visible = false;
            // 
            // button_trac
            // 
            this.button_trac.Location = new System.Drawing.Point(19, 65);
            this.button_trac.Name = "button_trac";
            this.button_trac.Size = new System.Drawing.Size(61, 23);
            this.button_trac.TabIndex = 4;
            this.button_trac.Text = "Add";
            this.button_trac.UseVisualStyleBackColor = true;
            this.button_trac.Click += new System.EventHandler(this.button_trac_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 10);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // button_update_tracking
            // 
            this.button_update_tracking.Location = new System.Drawing.Point(102, 65);
            this.button_update_tracking.Name = "button_update_tracking";
            this.button_update_tracking.Size = new System.Drawing.Size(61, 23);
            this.button_update_tracking.TabIndex = 1;
            this.button_update_tracking.Text = "Update";
            this.button_update_tracking.UseVisualStyleBackColor = true;
            this.button_update_tracking.Click += new System.EventHandler(this.button_update_tracking_Click);
            // 
            // groupBox_invest
            // 
            this.groupBox_invest.Controls.Add(this.button1);
            this.groupBox_invest.Controls.Add(this.radioButton_invest_scam);
            this.groupBox_invest.Controls.Add(this.radioButton_invest_paying);
            this.groupBox_invest.Controls.Add(this.radioButton_invest_all);
            this.groupBox_invest.Location = new System.Drawing.Point(10, 4);
            this.groupBox_invest.Name = "groupBox_invest";
            this.groupBox_invest.Size = new System.Drawing.Size(157, 147);
            this.groupBox_invest.TabIndex = 0;
            this.groupBox_invest.TabStop = false;
            this.groupBox_invest.Text = "Invest";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_invest_scam
            // 
            this.radioButton_invest_scam.AutoSize = true;
            this.radioButton_invest_scam.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton_invest_scam.Location = new System.Drawing.Point(6, 107);
            this.radioButton_invest_scam.Name = "radioButton_invest_scam";
            this.radioButton_invest_scam.Size = new System.Drawing.Size(52, 17);
            this.radioButton_invest_scam.TabIndex = 0;
            this.radioButton_invest_scam.Text = "Scam";
            this.radioButton_invest_scam.UseVisualStyleBackColor = false;
            this.radioButton_invest_scam.CheckedChanged += new System.EventHandler(this.radioButton_invest_scam_CheckedChanged);
            // 
            // radioButton_invest_paying
            // 
            this.radioButton_invest_paying.AutoSize = true;
            this.radioButton_invest_paying.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton_invest_paying.Checked = true;
            this.radioButton_invest_paying.Location = new System.Drawing.Point(6, 31);
            this.radioButton_invest_paying.Name = "radioButton_invest_paying";
            this.radioButton_invest_paying.Size = new System.Drawing.Size(57, 17);
            this.radioButton_invest_paying.TabIndex = 0;
            this.radioButton_invest_paying.TabStop = true;
            this.radioButton_invest_paying.Text = "Paying";
            this.radioButton_invest_paying.UseVisualStyleBackColor = false;
            this.radioButton_invest_paying.CheckedChanged += new System.EventHandler(this.radioButton_invest_paying_CheckedChanged);
            // 
            // radioButton_invest_all
            // 
            this.radioButton_invest_all.AutoSize = true;
            this.radioButton_invest_all.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton_invest_all.Location = new System.Drawing.Point(6, 71);
            this.radioButton_invest_all.Name = "radioButton_invest_all";
            this.radioButton_invest_all.Size = new System.Drawing.Size(66, 17);
            this.radioButton_invest_all.TabIndex = 0;
            this.radioButton_invest_all.Text = "Show All";
            this.radioButton_invest_all.UseVisualStyleBackColor = false;
            this.radioButton_invest_all.CheckedChanged += new System.EventHandler(this.radioButton_invest_all_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(1246, 322);
            this.splitContainer2.SplitterDistance = 743;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Percent,
            this.dailyprofit,
            this.updatestatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(743, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "PercenttPaid";
            this.Percent.HeaderText = "Percent";
            this.Percent.Name = "Percent";
            // 
            // dailyprofit
            // 
            this.dailyprofit.HeaderText = "Daily Profit";
            this.dailyprofit.Name = "dailyprofit";
            // 
            // updatestatus
            // 
            this.updatestatus.HeaderText = "Update Status";
            this.updatestatus.Name = "updatestatus";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dep,
            this.with});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(499, 322);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // name
            // 
            this.name.DataPropertyName = "AddressWeb";
            this.name.HeaderText = "Link";
            this.name.Name = "name";
            // 
            // dep
            // 
            this.dep.DataPropertyName = "Deposit";
            this.dep.HeaderText = "Deposit";
            this.dep.Name = "dep";
            // 
            // with
            // 
            this.with.DataPropertyName = "Withdraw";
            this.with.HeaderText = "Withdraw";
            this.with.Name = "with";
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.DataPropertyName = "PercenttPaid";
            this.dataGridViewProgressColumn1.HeaderText = "PercentWithdraw";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 488);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Tracking HYIP Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_heuristics)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_profit.ResumeLayout(false);
            this.groupBox_profit.PerformLayout();
            this.groupBox_tracking.ResumeLayout(false);
            this.groupBox_tracking.PerformLayout();
            this.groupBox_invest.ResumeLayout(false);
            this.groupBox_invest.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_tracking;
        private System.Windows.Forms.GroupBox groupBox_invest;
        private System.Windows.Forms.RadioButton radioButton_invest_paying;
        private System.Windows.Forms.RadioButton radioButton_invest_all;
        private System.Windows.Forms.RadioButton radioButton_invest_scam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_profit;
        private System.Windows.Forms.Label label_with;
        private System.Windows.Forms.Label label_dep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn with;
        private Sample.DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.Button button_update_tracking;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sample.DataGridViewProgressColumn Percent;
        private System.Windows.Forms.DataGridViewButtonColumn dailyprofit;
        private System.Windows.Forms.DataGridViewButtonColumn updatestatus;
        private System.Windows.Forms.Button button_trac;
        private System.Windows.Forms.Label label_webtracking;
        private System.Windows.Forms.Label label_total_tracking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.Button button_bk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView_heuristics;
        private System.Windows.Forms.Label label_heu_total;
        private System.Windows.Forms.TextBox textBox_heuritic_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_filter;
    }
}

