namespace BusinessCardsBase
{
    partial class frmSelectUser
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
            this.lbSelectUser = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSelectUser
            // 
            this.lbSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectUser.FormattingEnabled = true;
            this.lbSelectUser.Location = new System.Drawing.Point(12, 12);
            this.lbSelectUser.Name = "lbSelectUser";
            this.lbSelectUser.Size = new System.Drawing.Size(324, 134);
            this.lbSelectUser.TabIndex = 0;
            // 
            // btSelect
            // 
            this.btSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelect.Location = new System.Drawing.Point(180, 152);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "Выбрать";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(261, 152);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmSelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 185);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbSelectUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(364, 223);
            this.Name = "frmSelectUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSelectUser;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btCancel;
    }
}