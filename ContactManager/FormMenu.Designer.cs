namespace ContactManager
{
    partial class FormMenu
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
            this.CmdCreate = new MaterialSkin.Controls.MaterialButton();
            this.CmdSearch = new MaterialSkin.Controls.MaterialButton();
            this.CmdEdit = new MaterialSkin.Controls.MaterialButton();
            this.CmdDelete = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdCreate
            // 
            this.CmdCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreate.Depth = 0;
            this.CmdCreate.DrawShadows = true;
            this.CmdCreate.HighEmphasis = true;
            this.CmdCreate.Icon = null;
            this.CmdCreate.Location = new System.Drawing.Point(27, 29);
            this.CmdCreate.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.CmdCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(76, 36);
            this.CmdCreate.TabIndex = 1;
            this.CmdCreate.Text = "Create";
            this.CmdCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreate.UseAccentColor = false;
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            this.CmdCreate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // CmdSearch
            // 
            this.CmdSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearch.Depth = 0;
            this.CmdSearch.DrawShadows = true;
            this.CmdSearch.HighEmphasis = true;
            this.CmdSearch.Icon = null;
            this.CmdSearch.Location = new System.Drawing.Point(27, 95);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.CmdSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(78, 36);
            this.CmdSearch.TabIndex = 2;
            this.CmdSearch.Text = "Search";
            this.CmdSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearch.UseAccentColor = false;
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            this.CmdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // CmdEdit
            // 
            this.CmdEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdEdit.Depth = 0;
            this.CmdEdit.DrawShadows = true;
            this.CmdEdit.HighEmphasis = true;
            this.CmdEdit.Icon = null;
            this.CmdEdit.Location = new System.Drawing.Point(27, 161);
            this.CmdEdit.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.CmdEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(53, 36);
            this.CmdEdit.TabIndex = 3;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdEdit.UseAccentColor = false;
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            this.CmdEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // CmdDelete
            // 
            this.CmdDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdDelete.Depth = 0;
            this.CmdDelete.DrawShadows = true;
            this.CmdDelete.HighEmphasis = true;
            this.CmdDelete.Icon = null;
            this.CmdDelete.Location = new System.Drawing.Point(27, 227);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.CmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(73, 36);
            this.CmdDelete.TabIndex = 4;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdDelete.UseAccentColor = false;
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            this.CmdDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(16, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press Q to quit";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CmdCreate);
            this.materialCard1.Controls.Add(this.CmdSearch);
            this.materialCard1.Controls.Add(this.CmdDelete);
            this.materialCard1.Controls.Add(this.CmdEdit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 124);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(670, 290);
            this.materialCard1.TabIndex = 6;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 470);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Contact Manager Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Any_KeyDown);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton CmdCreate;
        private MaterialSkin.Controls.MaterialButton CmdSearch;
        private MaterialSkin.Controls.MaterialButton CmdEdit;
        private MaterialSkin.Controls.MaterialButton CmdDelete;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}