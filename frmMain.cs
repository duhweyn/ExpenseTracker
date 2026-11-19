namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        // All expenses in memory. The grid shows a filtered copy of this list.
        private readonly List<Expense> expenses = new();
        private string? currentFile = null;   // used in Phase 5 (Save/Load)
        private bool isDirty = false;         // true = unsaved changes

        public frmMain()
        {
            InitializeComponent();

            // Filter setup (done before wiring events so nothing fires early)
            cboFilterCategory.Items.Add("All");
            cboFilterCategory.Items.AddRange(new string[]
                { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboFilterCategory.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;

            // One handler per action, shared by the menu item and the toolbar button
            mnuAdd.Click += AddExpense; tsbAdd.Click += AddExpense;
            mnuEdit.Click += EditExpense; tsbEdit.Click += EditExpense;
            mnuDelete.Click += DeleteExpense; tsbDelete.Click += DeleteExpense;
            mnuExit.Click += (s, e) => Close();
            dgvExpenses.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) EditExpense(s, e); };

            // Any filter change refreshes the grid right away
            cboFilterCategory.SelectedIndexChanged += (s, e) => RefreshGrid();
            txtSearch.TextChanged += (s, e) => RefreshGrid();
            dtpFrom.ValueChanged += (s, e) => RefreshGrid();
            dtpTo.ValueChanged += (s, e) => RefreshGrid();
            chkDateRange.CheckedChanged += (s, e) =>
            {
                dtpFrom.Enabled = dtpTo.Enabled = chkDateRange.Checked;
                RefreshGrid();
            };

            // Budget change only needs the summary recalculated
            nudBudget.ValueChanged += (s, e) => UpdateSummary();

            // Live clock
            tmrClock.Tick += (s, e) => tslClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            tslClock.Text = DateTime.Now.ToString("hh:mm:ss tt");

            tslStatus.Text = "Ready.";
            RefreshGrid();
            UpdateTitle();
        }

        // ---------- Add / Edit / Delete ----------

        private void AddExpense(object? sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                Expense newExpense = form.GetExpense();
                // Next ID = highest existing ID + 1 (or 1 if the list is empty)
                newExpense.Id = expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
                expenses.Add(newExpense);
            }
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense added.";
        }

        private void EditExpense(object? sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.", "Edit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmExpense form = new frmExpense(selected))
            {
                // The form only changes 'selected' after validation passes
                if (form.ShowDialog(this) != DialogResult.OK) return;
            }
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense updated.";
        }

        private void DeleteExpense(object? sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\"?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            expenses.Remove(selected);
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense deleted.";
        }

        // ---------- Grid, filters, summary ----------

        private void RefreshGrid()
        {
            IEnumerable<Expense> query = expenses;

            // Category filter (index 0 is "All")
            if (cboFilterCategory.SelectedIndex > 0)
                query = query.Where(x => x.Category == cboFilterCategory.Text);

            // Search filter on Description, ignoring upper/lower case
            string term = txtSearch.Text.Trim();
            if (term != "")
                query = query.Where(x =>
                    x.Description.Contains(term, StringComparison.OrdinalIgnoreCase));

            // Date range filter
            if (chkDateRange.Checked)
                query = query.Where(x =>
                    x.Date.Date >= dtpFrom.Value.Date && x.Date.Date <= dtpTo.Value.Date);

            // Newest dates on top
            List<Expense> shown = query
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.Id)
                .ToList();

            dgvExpenses.DataSource = shown;
            ConfigureColumns();
            UpdateSummary();
        }

        private void ConfigureColumns()
        {
            if (dgvExpenses.Columns.Count == 0) return;

            dgvExpenses.Columns["Id"]!.Visible = false;
            dgvExpenses.Columns["Notes"]!.Visible = false;

            dgvExpenses.Columns["Date"]!.DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvExpenses.Columns["Amount"]!.HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void UpdateSummary()
        {
            // Shown count and total come from the filtered rows in the grid
            var shown = dgvExpenses.DataSource as List<Expense> ?? new List<Expense>();
            decimal total = shown.Sum(x => x.Amount);
            lblSummary.Text = $"Shown: {shown.Count}    Total: PHP {total:N2}";

            // "Remaining" uses ALL expenses from the current month, not the filtered ones
            DateTime today = DateTime.Today;
            decimal spentThisMonth = expenses
                .Where(x => x.Date.Year == today.Year && x.Date.Month == today.Month)
                .Sum(x => x.Amount);
            decimal remaining = nudBudget.Value - spentThisMonth;

            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Green;

            tslCount.Text = $"{expenses.Count} records";
        }

        // ---------- Title bar and unsaved flag ----------

        private void MarkDirty()
        {
            isDirty = true;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            this.Text = "Expense Tracker - " + name + (isDirty ? "*" : "");
        }
    }
}