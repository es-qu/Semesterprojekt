namespace ContactManager
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmdCreate = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(310, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // CmdCreate
            // 
            this.CmdCreate.Location = new System.Drawing.Point(206, 145);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(291, 49);
            this.CmdCreate.TabIndex = 1;
            this.CmdCreate.Text = "Create";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(206, 200);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(291, 49);
            this.CmdSearch.TabIndex = 2;
            this.CmdSearch.Text = "Search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(206, 255);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(291, 49);
            this.CmdEdit.TabIndex = 3;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(206, 310);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(291, 49);
            this.CmdDelete.TabIndex = 4;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.CmdCreate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Contact Manager Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdCreate;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdDelete;
    }
}