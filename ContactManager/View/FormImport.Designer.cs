namespace ContactManager.View
{
    partial class FormImport
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
            this.CmdImportCancel = new MaterialSkin.Controls.MaterialButton();
            this.CmdImportFile = new MaterialSkin.Controls.MaterialButton();
            this.DataGridViewImportPreview = new System.Windows.Forms.DataGridView();
            this.CmdImportConfirm = new MaterialSkin.Controls.MaterialButton();
            this.LblImportDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImportPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdImportCancel
            // 
            this.CmdImportCancel.AutoSize = false;
            this.CmdImportCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdImportCancel.Depth = 0;
            this.CmdImportCancel.DrawShadows = true;
            this.CmdImportCancel.HighEmphasis = true;
            this.CmdImportCancel.Icon = null;
            this.CmdImportCancel.Location = new System.Drawing.Point(712, 513);
            this.CmdImportCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdImportCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdImportCancel.Name = "CmdImportCancel";
            this.CmdImportCancel.Size = new System.Drawing.Size(88, 30);
            this.CmdImportCancel.TabIndex = 2;
            this.CmdImportCancel.Text = "Cancel";
            this.CmdImportCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdImportCancel.UseAccentColor = false;
            this.CmdImportCancel.UseVisualStyleBackColor = true;
            this.CmdImportCancel.Click += new System.EventHandler(this.CmdImportCancel_Click);
            // 
            // CmdImportFile
            // 
            this.CmdImportFile.AutoSize = false;
            this.CmdImportFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdImportFile.Depth = 0;
            this.CmdImportFile.DrawShadows = true;
            this.CmdImportFile.HighEmphasis = true;
            this.CmdImportFile.Icon = null;
            this.CmdImportFile.Location = new System.Drawing.Point(8, 77);
            this.CmdImportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdImportFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdImportFile.Name = "CmdImportFile";
            this.CmdImportFile.Size = new System.Drawing.Size(129, 45);
            this.CmdImportFile.TabIndex = 0;
            this.CmdImportFile.Text = "IMPORT FILE";
            this.CmdImportFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdImportFile.UseAccentColor = false;
            this.CmdImportFile.UseVisualStyleBackColor = true;
            this.CmdImportFile.Click += new System.EventHandler(this.CmdImportFile_Click);
            // 
            // DataGridViewImportPreview
            // 
            this.DataGridViewImportPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewImportPreview.Location = new System.Drawing.Point(152, 77);
            this.DataGridViewImportPreview.Name = "DataGridViewImportPreview";
            this.DataGridViewImportPreview.Size = new System.Drawing.Size(648, 429);
            this.DataGridViewImportPreview.TabIndex = 138;
            this.DataGridViewImportPreview.TabStop = false;
            // 
            // CmdImportConfirm
            // 
            this.CmdImportConfirm.AutoSize = false;
            this.CmdImportConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdImportConfirm.Depth = 0;
            this.CmdImportConfirm.DrawShadows = true;
            this.CmdImportConfirm.HighEmphasis = true;
            this.CmdImportConfirm.Icon = null;
            this.CmdImportConfirm.Location = new System.Drawing.Point(152, 513);
            this.CmdImportConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdImportConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdImportConfirm.Name = "CmdImportConfirm";
            this.CmdImportConfirm.Size = new System.Drawing.Size(88, 30);
            this.CmdImportConfirm.TabIndex = 1;
            this.CmdImportConfirm.Text = "Confirm";
            this.CmdImportConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdImportConfirm.UseAccentColor = false;
            this.CmdImportConfirm.UseVisualStyleBackColor = true;
            this.CmdImportConfirm.Click += new System.EventHandler(this.CmdImportConfirm_Click);
            // 
            // LblImportDescription
            // 
            this.LblImportDescription.AutoSize = true;
            this.LblImportDescription.Location = new System.Drawing.Point(11, 130);
            this.LblImportDescription.Name = "LblImportDescription";
            this.LblImportDescription.Size = new System.Drawing.Size(78, 13);
            this.LblImportDescription.TabIndex = 140;
            this.LblImportDescription.Text = "only CSV with ;";
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 551);
            this.Controls.Add(this.LblImportDescription);
            this.Controls.Add(this.CmdImportConfirm);
            this.Controls.Add(this.DataGridViewImportPreview);
            this.Controls.Add(this.CmdImportFile);
            this.Controls.Add(this.CmdImportCancel);
            this.Name = "FormImport";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImport";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewImportPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton CmdImportCancel;
        private MaterialSkin.Controls.MaterialButton CmdImportFile;
        private System.Windows.Forms.DataGridView DataGridViewImportPreview;
        private MaterialSkin.Controls.MaterialButton CmdImportConfirm;
        private System.Windows.Forms.Label LblImportDescription;
    }
}