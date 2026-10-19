using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmExpense : Form
	{
		private DataTable expenseTable;
		private sharedClass db = new sharedClass(); // Instantiate your sharedClass

		public frmExpense()
		{
			InitializeComponent();
			LoadCategories();
			LoadExpenses();

			// Wire up event handlers
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
		}

		private void LoadCategories()
		{
			cmbCategory.Items.Add("Inventory & Goods");
			cmbCategory.Items.Add("Rent & Occupancy");
			cmbCategory.Items.Add("Utilities & Bills");
			cmbCategory.Items.Add("Payroll & Salaries");
			cmbCategory.Items.Add("Marketing & Ads");
			cmbCategory.Items.Add("Transportation");
			//cmbCategory.Items.Add("Software & POS");
			cmbCategory.Items.Add("Maintenance & Repairs");
			cmbCategory.Items.Add("Taxes & Insurance");
			cmbCategory.Items.Add("Miscellaneous");
			cmbCategory.Items.Add("Other");

			if (cmbCategory.Items.Count > 0)
			{
				cmbCategory.SelectedIndex = 0;
			}
		}

		private void LoadExpenses()
		{
			string query = "SELECT Id, Category, Amount, ExpenseDate AS Date, Description FROM tblExpenses ORDER BY ExpenseDate DESC";

			// Using your sharedClass GetData method to fetch data into a DataTable (needed for search filtering)
			expenseTable = sharedClass.GetData(query);
			dgvExpenses.DataSource = expenseTable;

			// Format grid columns
			if (dgvExpenses.Columns["Amount"] != null)
			{
				dgvExpenses.Columns["Amount"].DefaultCellStyle.Format = "C2";
			}
			if (dgvExpenses.Columns["Date"] != null)
			{
				dgvExpenses.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
			}
			if (dgvExpenses.Columns["Id"] != null)
			{
				dgvExpenses.Columns["Id"].Visible = false; // Hide primary key ID column
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (cmbCategory.SelectedItem == null)
			{
				MessageBox.Show("Please select an expense category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
			{
				MessageBox.Show("Please enter a valid numeric amount greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtAmount.Focus();
				return;
			}

			string category = cmbCategory.SelectedItem.ToString();
			string date = dtpExpenseDate.Value.ToString("yyyy-MM-dd");
			string description = string.IsNullOrWhiteSpace(txtNotes.Text) ? "" : txtNotes.Text.Trim().Replace("'", "''");

			// Build query for your ExecuteQueries method
			string query = string.Format(
				"INSERT INTO tblExpenses (Category, Amount, ExpenseDate, Description) VALUES ('{0}', {1}, '{2}', '{3}')",
				category, amount, date, description
			);

			try
			{
				db.ExecuteQueries(query);
				MessageBox.Show("Expense saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearForm();
				LoadExpenses(); // Refresh grid data from database
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void ClearForm()
		{
			// Using your sharedClass clearData method
			db.clearData(cmbCategory, txtAmount, txtNotes, txtSearch);

			if (cmbCategory.Items.Count > 0)
			{
				cmbCategory.SelectedIndex = 0;
			}
			dtpExpenseDate.Value = DateTime.Now;
			dgvExpenses.ClearSelection();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvExpenses.SelectedRows.Count > 0)
			{
				var confirmResult = MessageBox.Show(db.message, db.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirmResult == DialogResult.Yes)
				{
					int id = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["Id"].Value);
					string query = "DELETE FROM tblExpenses WHERE Id = " + id;

					try
					{
						db.ExecuteQueries(query);
						MessageBox.Show("Expense record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ClearForm();
						LoadExpenses(); // Refresh grid data
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error deleting record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (expenseTable == null) return;

			string filterText = txtSearch.Text.Trim().Replace("'", "''");

			if (!string.IsNullOrEmpty(filterText))
			{
				expenseTable.DefaultView.RowFilter = string.Format("Category LIKE '%{0}%' OR Description LIKE '%{0}%'", filterText);
			}
			else
			{
				expenseTable.DefaultView.RowFilter = string.Empty;
			}
		}
	}
}