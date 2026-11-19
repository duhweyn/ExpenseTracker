namespace ExpenseTracker
{
    partial class frmExpense
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
            components = new System.ComponentModel.Container();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            cboCategory = new ComboBox();
            nudAmount = new NumericUpDown();
            grpPayment = new GroupBox();
            rdoCard = new RadioButton();
            rdoGCash = new RadioButton();
            rdoCash = new RadioButton();
            chkRecurring = new CheckBox();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            lblDate = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblAmount = new Label();
            lblNotes = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(112, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(260, 23);
            dtpDate.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 53);
            txtDescription.MaxLength = 50;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(260, 23);
            txtDescription.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(112, 94);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 23);
            cboCategory.TabIndex = 2;
            // 
            // nudAmount
            // 
            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(112, 135);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(260, 23);
            nudAmount.TabIndex = 3;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Controls.Add(rdoGCash);
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Location = new Point(12, 176);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(360, 53);
            grpPayment.TabIndex = 4;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            // 
            // rdoCard
            // 
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(128, 22);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(50, 19);
            rdoCard.TabIndex = 7;
            rdoCard.TabStop = true;
            rdoCard.Text = "Card";
            rdoCard.UseVisualStyleBackColor = true;
            // 
            // rdoGCash
            // 
            rdoGCash.AutoSize = true;
            rdoGCash.Location = new Point(63, 22);
            rdoGCash.Name = "rdoGCash";
            rdoGCash.Size = new Size(59, 19);
            rdoGCash.TabIndex = 6;
            rdoGCash.TabStop = true;
            rdoGCash.Text = "GCash";
            rdoGCash.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            rdoCash.AutoSize = true;
            rdoCash.Location = new Point(6, 22);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(51, 19);
            rdoCash.TabIndex = 5;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            rdoCash.UseVisualStyleBackColor = true;
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(12, 247);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(125, 19);
            chkRecurring.TabIndex = 5;
            chkRecurring.Text = "Recurring monthly";
            chkRecurring.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(56, 297);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(316, 70);
            txtNotes.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(216, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(297, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 53);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Descripton:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 94);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 135);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 12;
            lblAmount.Text = "Amount:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(12, 297);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 13;
            lblNotes.Text = "Notes";
            // 
            // frmExpense
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(396, 421);
            Controls.Add(lblNotes);
            Controls.Add(lblAmount);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(chkRecurring);
            Controls.Add(grpPayment);
            Controls.Add(nudAmount);
            Controls.Add(cboCategory);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmExpense";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private ComboBox cboCategory;
        private NumericUpDown nudAmount;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoCard;
        private RadioButton rdoGCash;
        private CheckBox chkRecurring;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblDate;
        private Label lblNotes;
        private Label lblAmount;
    }
}