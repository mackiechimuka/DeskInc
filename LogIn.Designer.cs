namespace DeskInc
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.NameLabel = new System.Windows.Forms.Label();
            this.LUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LPasswordLabel = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(56, 227);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "First Name";
            // 
            // LUserNameTextBox
            // 
            this.LUserNameTextBox.Location = new System.Drawing.Point(181, 227);
            this.LUserNameTextBox.Multiline = true;
            this.LUserNameTextBox.Name = "LUserNameTextBox";
            this.LUserNameTextBox.Size = new System.Drawing.Size(198, 40);
            this.LUserNameTextBox.TabIndex = 4;
            // 
            // LPasswordLabel
            // 
            this.LPasswordLabel.AutoSize = true;
            this.LPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPasswordLabel.Location = new System.Drawing.Point(56, 300);
            this.LPasswordLabel.Name = "LPasswordLabel";
            this.LPasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.LPasswordLabel.TabIndex = 5;
            this.LPasswordLabel.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(181, 300);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(198, 39);
            this.TxtPassword.TabIndex = 6;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogIn.Location = new System.Drawing.Point(181, 362);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(133, 40);
            this.BtnLogIn.TabIndex = 7;
            this.BtnLogIn.Text = "Login";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LPasswordLabel);
            this.Controls.Add(this.LUserNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox LUserNameTextBox;
        private System.Windows.Forms.Label LPasswordLabel;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}