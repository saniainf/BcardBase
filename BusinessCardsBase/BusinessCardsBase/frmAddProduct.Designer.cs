namespace BusinessCardsBase
{
    partial class frmAddProduct
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
            this.lbTitleFile = new System.Windows.Forms.ListBox();
            this.lblTitleFile = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.dateGet = new System.Windows.Forms.DateTimePicker();
            this.lblDateGet = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.cbBack = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.pnlDragDrop = new System.Windows.Forms.Panel();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleFile
            // 
            this.lbTitleFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitleFile.FormattingEnabled = true;
            this.lbTitleFile.Location = new System.Drawing.Point(86, 15);
            this.lbTitleFile.Name = "lbTitleFile";
            this.lbTitleFile.Size = new System.Drawing.Size(254, 82);
            this.lbTitleFile.TabIndex = 0;
            // 
            // lblTitleFile
            // 
            this.lblTitleFile.AutoSize = true;
            this.lblTitleFile.Location = new System.Drawing.Point(12, 15);
            this.lblTitleFile.Name = "lblTitleFile";
            this.lblTitleFile.Size = new System.Drawing.Size(57, 13);
            this.lblTitleFile.TabIndex = 1;
            this.lblTitleFile.Text = "Название";
            // 
            // cbClient
            // 
            this.cbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(86, 105);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(141, 21);
            this.cbClient.TabIndex = 2;
            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 108);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(55, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Заказчик";
            // 
            // cbManager
            // 
            this.cbManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(86, 132);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(141, 21);
            this.cbManager.TabIndex = 2;
            // 
            // lblManager
            // 
            this.lblManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(12, 135);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(60, 13);
            this.lblManager.TabIndex = 1;
            this.lblManager.Text = "Менеджер";
            // 
            // dateGet
            // 
            this.dateGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateGet.Location = new System.Drawing.Point(86, 159);
            this.dateGet.Name = "dateGet";
            this.dateGet.Size = new System.Drawing.Size(141, 20);
            this.dateGet.TabIndex = 3;
            // 
            // lblDateGet
            // 
            this.lblDateGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateGet.AutoSize = true;
            this.lblDateGet.Location = new System.Drawing.Point(12, 162);
            this.lblDateGet.Name = "lblDateGet";
            this.lblDateGet.Size = new System.Drawing.Size(74, 13);
            this.lblDateGet.TabIndex = 1;
            this.lblDateGet.Text = "Дата приема";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 188);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(40, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Тираж";
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(12, 214);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(44, 13);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Оборот";
            // 
            // cbBack
            // 
            this.cbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBack.AutoSize = true;
            this.cbBack.Location = new System.Drawing.Point(86, 213);
            this.cbBack.Name = "cbBack";
            this.cbBack.Size = new System.Drawing.Size(38, 17);
            this.cbBack.TabIndex = 5;
            this.cbBack.Text = "да";
            this.cbBack.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(184, 235);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(265, 235);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pnlDragDrop
            // 
            this.pnlDragDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDragDrop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDragDrop.Location = new System.Drawing.Point(233, 105);
            this.pnlDragDrop.MinimumSize = new System.Drawing.Size(106, 121);
            this.pnlDragDrop.Name = "pnlDragDrop";
            this.pnlDragDrop.Size = new System.Drawing.Size(106, 121);
            this.pnlDragDrop.TabIndex = 8;
            // 
            // numAmount
            // 
            this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmount.Location = new System.Drawing.Point(86, 185);
            this.numAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(141, 20);
            this.numAmount.TabIndex = 9;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 264);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.pnlDragDrop);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbBack);
            this.Controls.Add(this.dateGet);
            this.Controls.Add(this.cbManager);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDateGet);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblTitleFile);
            this.Controls.Add(this.lbTitleFile);
            this.MinimumSize = new System.Drawing.Size(368, 302);
            this.Name = "frmAddProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить изделие";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTitleFile;
        private System.Windows.Forms.Label lblTitleFile;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cbManager;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.DateTimePicker dateGet;
        private System.Windows.Forms.Label lblDateGet;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.CheckBox cbBack;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel pnlDragDrop;
        private System.Windows.Forms.NumericUpDown numAmount;
    }
}