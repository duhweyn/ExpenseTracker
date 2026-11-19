namespace ExpenseTracker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            tslStatus = new ToolStripStatusLabel();
            tslCount = new ToolStripStatusLabel();
            tslClock = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            chkDateRange = new CheckBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cboFilterCategory = new ComboBox();
            lblCategory = new Label();
            pnlSummary = new Panel();
            lblRemaining = new Label();
            nudBudget = new NumericUpDown();
            lblMonthly = new Label();
            lblSummary = new Label();
            dgvExpenses = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(844, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, toolStripSeparator1, mnuExit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(146, 22);
            mnuNew.Text = "New";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(146, 22);
            mnuOpen.Text = "Open";
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(146, 22);
            mnuSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(146, 22);
            mnuExit.Text = "Exit";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(62, 20);
            toolStripMenuItem2.Text = "Expense";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(107, 22);
            mnuAdd.Text = "Add";
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(107, 22);
            mnuEdit.Text = "Edit";
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(107, 22);
            mnuDelete.Text = "Delete";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(44, 20);
            toolStripMenuItem3.Text = "Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(107, 22);
            mnuAbout.Text = "About";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete, tsbSave });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(844, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(33, 22);
            tsbAdd.Text = "Add";
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(31, 22);
            tsbEdit.Text = "Edit";
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(44, 22);
            tsbDelete.Text = "Delete";
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(35, 22);
            tsbSave.Text = "Save";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslStatus, tslCount, tslClock });
            statusStrip1.Location = new Point(0, 459);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(844, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            tslStatus.Name = "tslStatus";
            tslStatus.Size = new Size(728, 17);
            tslStatus.Spring = true;
            tslStatus.Text = "tslStatus";
            tslStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tslCount
            // 
            tslCount.Name = "tslCount";
            tslCount.Size = new Size(52, 17);
            tslCount.Text = "tslCount";
            // 
            // tslClock
            // 
            tslClock.Name = "tslClock";
            tslClock.Size = new Size(49, 17);
            tslClock.Text = "tslClock";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(cboFilterCategory);
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 49);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(844, 89);
            pnlFilter.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(331, 50);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 7;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(307, 54);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(18, 15);
            lblTo.TabIndex = 6;
            lblTo.Text = "to";
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(101, 50);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 5;
            // 
            // chkDateRange
            // 
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(12, 52);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Size = new Size(83, 19);
            chkDateRange.TabIndex = 4;
            chkDateRange.Text = "Date range";
            chkDateRange.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(258, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(273, 23);
            txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(210, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Location = new Point(73, 14);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(121, 23);
            cboFilterCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 18);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Controls.Add(lblMonthly);
            pnlSummary.Controls.Add(lblSummary);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 389);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(844, 70);
            pnlSummary.TabIndex = 4;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemaining.ForeColor = Color.ForestGreen;
            lblRemaining.Location = new Point(246, 41);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(79, 15);
            lblRemaining.TabIndex = 3;
            lblRemaining.Text = "lblRemaining";
            // 
            // nudBudget
            // 
            nudBudget.DecimalPlaces = 2;
            nudBudget.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudBudget.Location = new Point(114, 37);
            nudBudget.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(120, 23);
            nudBudget.TabIndex = 2;
            nudBudget.ThousandsSeparator = true;
            nudBudget.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Location = new Point(12, 41);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(96, 15);
            lblMonthly.TabIndex = 1;
            lblMonthly.Text = "Monthly budget:";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(12, 12);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(159, 15);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Shown: 0      Total: PHP 0.00";
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 138);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(844, 251);
            dgvExpenses.TabIndex = 5;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(760, 450);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuAbout;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripButton tsbSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslStatus;
        private ToolStripStatusLabel tslCount;
        private ToolStripStatusLabel tslClock;
        private Panel pnlFilter;
        private Panel pnlSummary;
        private DataGridView dgvExpenses;
        private System.Windows.Forms.Timer tmrClock;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboFilterCategory;
        private Label lblCategory;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private CheckBox chkDateRange;
        private Label lblSummary;
        private Label lblRemaining;
        private NumericUpDown nudBudget;
        private Label lblMonthly;
    }
}
