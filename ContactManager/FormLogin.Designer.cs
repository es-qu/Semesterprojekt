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
            this.TxtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.CmdLogin = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtUsername.Location = new System.Drawing.Point(182, 170);
            this.TxtUsername.MaxLength = 50;
            this.TxtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(366, 50);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "";
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPassword.Location = new System.Drawing.Point(182, 295);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Password = true;
            this.TxtPassword.Size = new System.Drawing.Size(366, 50);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Text = "";
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(179, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(179, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // CmdLogin
            // 
            this.CmdLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdLogin.Depth = 0;
            this.CmdLogin.DrawShadows = true;
            this.CmdLogin.HighEmphasis = true;
            this.CmdLogin.Icon = null;
            this.CmdLogin.Location = new System.Drawing.Point(182, 400);
            this.CmdLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CmdLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(68, 36);
            this.CmdLogin.TabIndex = 5;
            this.CmdLogin.Text = "Log in";
            this.CmdLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdLogin.UseAccentColor = false;
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 475);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sizable = false;
            this.Text = "Contact Manager Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TxtUsername;
        private MaterialSkin.Controls.MaterialTextBox TxtPassword;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialButton CmdLogin;
    }
}