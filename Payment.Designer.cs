namespace DeskInc
{
    partial class Payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountNumb = new System.Windows.Forms.NumericUpDown();
            this.PriceDown = new System.Windows.Forms.NumericUpDown();
            this.DeskQouteNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Changelabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayExcelBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.paymentGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QExcelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskQouteNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Brown;
            this.groupBox1.Controls.Add(this.AmountNumb);
            this.groupBox1.Controls.Add(this.PriceDown);
            this.groupBox1.Controls.Add(this.DeskQouteNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Changelabel);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.paymentGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Group";
            // 
            // AmountNumb
            // 
            this.AmountNumb.DecimalPlaces = 2;
            this.AmountNumb.Location = new System.Drawing.Point(105, 183);
            this.AmountNumb.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.AmountNumb.Name = "AmountNumb";
            this.AmountNumb.Size = new System.Drawing.Size(148, 23);
            this.AmountNumb.TabIndex = 10;
            this.AmountNumb.ThousandsSeparator = true;
            // 
            // PriceDown
            // 
            this.PriceDown.DecimalPlaces = 2;
            this.PriceDown.Location = new System.Drawing.Point(105, 149);
            this.PriceDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PriceDown.Name = "PriceDown";
            this.PriceDown.ReadOnly = true;
            this.PriceDown.Size = new System.Drawing.Size(148, 23);
            this.PriceDown.TabIndex = 9;
            this.PriceDown.ThousandsSeparator = true;
            // 
            // DeskQouteNum
            // 
            this.DeskQouteNum.Location = new System.Drawing.Point(105, 107);
            this.DeskQouteNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.DeskQouteNum.Name = "DeskQouteNum";
            this.DeskQouteNum.ReadOnly = true;
            this.DeskQouteNum.Size = new System.Drawing.Size(148, 23);
            this.DeskQouteNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price:";
            // 
            // Changelabel
            // 
            this.Changelabel.AutoSize = true;
            this.Changelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Changelabel.Location = new System.Drawing.Point(51, 232);
            this.Changelabel.Name = "Changelabel";
            this.Changelabel.Size = new System.Drawing.Size(88, 25);
            this.Changelabel.TabIndex = 6;
            this.Changelabel.Text = "Change";
            this.Changelabel.Visible = false;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Amount.Location = new System.Drawing.Point(6, 178);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(86, 25);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qoute Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayExcelBtn);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.BtnPay);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(781, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 232);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // PayExcelBtn
            // 
            this.PayExcelBtn.AutoSize = true;
            this.PayExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PayExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayExcelBtn.Location = new System.Drawing.Point(20, 183);
            this.PayExcelBtn.Name = "PayExcelBtn";
            this.PayExcelBtn.Size = new System.Drawing.Size(107, 43);
            this.PayExcelBtn.TabIndex = 3;
            this.PayExcelBtn.Text = "Export Excel";
            this.PayExcelBtn.UseVisualStyleBackColor = false;
            this.PayExcelBtn.Click += new System.EventHandler(this.PayExcelBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(20, 76);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(105, 41);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.Location = new System.Drawing.Point(20, 22);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(105, 41);
            this.BtnPay.TabIndex = 0;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // paymentGrid
            // 
            this.paymentGrid.Location = new System.Drawing.Point(259, 31);
            this.paymentGrid.Name = "paymentGrid";
            this.paymentGrid.Size = new System.Drawing.Size(516, 226);
            this.paymentGrid.TabIndex = 11;
            this.paymentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentGrid_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 127);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Brown;
            this.groupBox3.Controls.Add(this.SearchTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.QExcelBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 225);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qoutes Group";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(220, 44);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(238, 23);
            this.SearchTxt.TabIndex = 7;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(32, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search By Customer Name:";
            // 
            // QExcelBtn
            // 
            this.QExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.QExcelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QExcelBtn.Location = new System.Drawing.Point(871, 116);
            this.QExcelBtn.Name = "QExcelBtn";
            this.QExcelBtn.Size = new System.Drawing.Size(80, 48);
            this.QExcelBtn.TabIndex = 5;
            this.QExcelBtn.Text = "Export Excel";
            this.QExcelBtn.UseVisualStyleBackColor = false;
            this.QExcelBtn.Click += new System.EventHandler(this.QExcelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(374, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Qoute to Pay";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.mainMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(82, 25);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payment";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskQouteNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AmountNumb;
        private System.Windows.Forms.NumericUpDown PriceDown;
        private System.Windows.Forms.NumericUpDown DeskQouteNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Changelabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PayExcelBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.DataGridView paymentGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button QExcelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label4;
    }
}