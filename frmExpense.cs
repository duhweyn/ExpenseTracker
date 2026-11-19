namespace ExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;

        // existing == null means Add, otherwise Edit
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            cboCategory.Items.AddRange(new string[]
                { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboCategory.SelectedIndex = 0;
            dtpDate.MaxDate = DateTime.Today;   // no future dates
            rdoCash.Checked = true;             // default payment

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";

                dtpDate.Value = existing.Date > DateTime.Today ? DateTime.Today : existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;

                if (existing.PaymentMethod == "GCash") rdoGCash.Checked = true;
                else if (existing.PaymentMethod == "Card") rdoCard.Checked = true;
                else rdoCash.Checked = true;
            }
        }

        // The main form calls this after ShowDialog() returns OK
        public Expense GetExpense() => expense;

        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Description is required.");
                ok = false;
            }
            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(cboCategory, "Please choose a category.");
                ok = false;
            }
            if (nudAmount.Value <= 0)
            {
                errorProvider.SetError(nudAmount, "Amount must be greater than 0.");
                ok = false;
            }
            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;   // stay open and show the errors

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = rdoCash.Checked ? "Cash"
                                  : rdoGCash.Checked ? "GCash" : "Card";
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            this.DialogResult = DialogResult.OK;   // closes the form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}