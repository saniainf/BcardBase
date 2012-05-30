namespace BusinessCardsBase
{
    partial class MainFormBase
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripServiceMangerBase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripServicesExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptionsChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptionsProgramSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLbUserSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSp1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLbManager = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComBoxManager = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSp2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLbStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComBoxStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSp3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtMakeSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSp4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtUpdate = new System.Windows.Forms.ToolStripButton();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripService,
            this.menuStripOptions,
            this.menuStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripService
            // 
            this.menuStripService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripServiceMangerBase,
            this.menuStripServicesExit});
            this.menuStripService.Name = "menuStripService";
            this.menuStripService.Size = new System.Drawing.Size(59, 20);
            this.menuStripService.Text = "Сервис";
            // 
            // menuStripServiceMangerBase
            // 
            this.menuStripServiceMangerBase.Image = global::BusinessCardsBase.Properties.Resources.group;
            this.menuStripServiceMangerBase.Name = "menuStripServiceMangerBase";
            this.menuStripServiceMangerBase.Size = new System.Drawing.Size(170, 22);
            this.menuStripServiceMangerBase.Text = "База менеджеров";
            this.menuStripServiceMangerBase.Click += new System.EventHandler(this.menuStripServiceMangerBase_Click);
            // 
            // menuStripServicesExit
            // 
            this.menuStripServicesExit.Name = "menuStripServicesExit";
            this.menuStripServicesExit.Size = new System.Drawing.Size(170, 22);
            this.menuStripServicesExit.Text = "Выход";
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOptionsChangeUser,
            this.menuStripOptionsProgramSettings});
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(79, 20);
            this.menuStripOptions.Text = "Настройки";
            // 
            // menuStripOptionsChangeUser
            // 
            this.menuStripOptionsChangeUser.Image = global::BusinessCardsBase.Properties.Resources.user_go;
            this.menuStripOptionsChangeUser.Name = "menuStripOptionsChangeUser";
            this.menuStripOptionsChangeUser.Size = new System.Drawing.Size(203, 22);
            this.menuStripOptionsChangeUser.Text = "Сменить пользователя";
            this.menuStripOptionsChangeUser.Click += new System.EventHandler(this.menuStripOptionsChangeUser_Click);
            // 
            // menuStripOptionsProgramSettings
            // 
            this.menuStripOptionsProgramSettings.Image = global::BusinessCardsBase.Properties.Resources.wrench;
            this.menuStripOptionsProgramSettings.Name = "menuStripOptionsProgramSettings";
            this.menuStripOptionsProgramSettings.Size = new System.Drawing.Size(203, 22);
            this.menuStripOptionsProgramSettings.Text = "Настройки программы";
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuStripHelp.Image = global::BusinessCardsBase.Properties.Resources.help;
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(84, 20);
            this.menuStripHelp.Text = "Помощь";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLbUser,
            this.statusStripLbUserSelect});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripLbUser
            // 
            this.statusStripLbUser.Name = "statusStripLbUser";
            this.statusStripLbUser.Size = new System.Drawing.Size(87, 17);
            this.statusStripLbUser.Text = "Пользователь:";
            // 
            // statusStripLbUserSelect
            // 
            this.statusStripLbUserSelect.Name = "statusStripLbUserSelect";
            this.statusStripLbUserSelect.Size = new System.Drawing.Size(57, 17);
            this.statusStripLbUserSelect.Text = "temp text";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtAdd,
            this.toolStripSp1,
            this.toolStripLbManager,
            this.toolStripComBoxManager,
            this.toolStripSp2,
            this.toolStripLbStatus,
            this.toolStripComBoxStatus,
            this.toolStripSp3,
            this.toolStripBtMakeSelection,
            this.toolStripSp4,
            this.toolStripBtUpdate});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(734, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripBtAdd
            // 
            this.toolStripBtAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtAdd.Image")));
            this.toolStripBtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtAdd.Name = "toolStripBtAdd";
            this.toolStripBtAdd.Size = new System.Drawing.Size(126, 22);
            this.toolStripBtAdd.Text = "Добавить изделие";
            this.toolStripBtAdd.Click += new System.EventHandler(this.toolStripBtAdd_Click);
            // 
            // toolStripSp1
            // 
            this.toolStripSp1.Name = "toolStripSp1";
            this.toolStripSp1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLbManager
            // 
            this.toolStripLbManager.Name = "toolStripLbManager";
            this.toolStripLbManager.Size = new System.Drawing.Size(68, 22);
            this.toolStripLbManager.Text = "Менеджер:";
            // 
            // toolStripComBoxManager
            // 
            this.toolStripComBoxManager.Name = "toolStripComBoxManager";
            this.toolStripComBoxManager.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSp2
            // 
            this.toolStripSp2.Name = "toolStripSp2";
            this.toolStripSp2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLbStatus
            // 
            this.toolStripLbStatus.Name = "toolStripLbStatus";
            this.toolStripLbStatus.Size = new System.Drawing.Size(46, 22);
            this.toolStripLbStatus.Text = "Статус:";
            // 
            // toolStripComBoxStatus
            // 
            this.toolStripComBoxStatus.Name = "toolStripComBoxStatus";
            this.toolStripComBoxStatus.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSp3
            // 
            this.toolStripSp3.Name = "toolStripSp3";
            this.toolStripSp3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtMakeSelection
            // 
            this.toolStripBtMakeSelection.Image = global::BusinessCardsBase.Properties.Resources.magnifier;
            this.toolStripBtMakeSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtMakeSelection.Name = "toolStripBtMakeSelection";
            this.toolStripBtMakeSelection.Size = new System.Drawing.Size(62, 22);
            this.toolStripBtMakeSelection.Text = "Поиск";
            // 
            // toolStripSp4
            // 
            this.toolStripSp4.Name = "toolStripSp4";
            this.toolStripSp4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtUpdate
            // 
            this.toolStripBtUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtUpdate.Image = global::BusinessCardsBase.Properties.Resources.arrow_refresh;
            this.toolStripBtUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtUpdate.Name = "toolStripBtUpdate";
            this.toolStripBtUpdate.Size = new System.Drawing.Size(81, 22);
            this.toolStripBtUpdate.Text = "Обновить";
            this.toolStripBtUpdate.Click += new System.EventHandler(this.toolStripBtUpdate_Click);
            // 
            // DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 49);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.ReadOnly = true;
            this.DataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(734, 441);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // MainFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "MainFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База визиток";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripService;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ToolStripButton toolStripBtAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSp1;
        private System.Windows.Forms.ToolStripLabel toolStripLbManager;
        private System.Windows.Forms.ToolStripComboBox toolStripComBoxManager;
        private System.Windows.Forms.ToolStripComboBox toolStripComBoxStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSp2;
        private System.Windows.Forms.ToolStripButton toolStripBtMakeSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSp3;
        private System.Windows.Forms.ToolStripButton toolStripBtUpdate;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLbUser;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLbUserSelect;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptionsChangeUser;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptionsProgramSettings;
        private System.Windows.Forms.ToolStripMenuItem menuStripServiceMangerBase;
        private System.Windows.Forms.ToolStripMenuItem menuStripServicesExit;
        private System.Windows.Forms.ToolStripLabel toolStripLbStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSp4;
    }
}

