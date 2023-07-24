namespace ContactManager
{
    partial class FormLogin
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CmdLogin = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CmdLogin);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.TxtPassword);
            this.materialCard1.Controls.Add(this.TxtUsername);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(12, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.materialCard1.Size = new System.Drawing.Size(441, 390);
            this.materialCard1.TabIndex = 6;
            // 
            // CmdLogin
            // 
            this.CmdLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdLogin.Depth = 0;
            this.CmdLogin.DrawShadows = true;
            this.CmdLogin.HighEmphasis = true;
            this.CmdLogin.Icon = null;
            this.CmdLogin.Location = new System.Drawing.Point(100, 312);
            this.CmdLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(68, 36);
            this.CmdLogin.TabIndex = 10;
            this.CmdLogin.Text = "Log in";
            this.CmdLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdLogin.UseAccentColor = false;
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(99, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(99, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPassword.Location = new System.Drawing.Point(101, 214);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Password = true;
            this.TxtPassword.Size = new System.Drawing.Size(242, 50);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.Text = "";
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtUsername.Location = new System.Drawing.Point(100, 91);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUsername.MaxLength = 50;
            this.TxtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(243, 50);
            this.TxtUsername.TabIndex = 6;
            this.TxtUsername.Text = "";
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 487);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager Login";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton CmdLogin;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialTextBox TxtPassword;
        private MaterialSkin.Controls.MaterialTextBox TxtUsername;
    }
}