using System.Windows.Forms;

namespace library_automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            if (BooksList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select the Borrowed Book or Books.");
            }

            var selectedItems = BooksList.SelectedItems.Cast<object>().ToList();

            foreach (var item in selectedItems)
            {
                BorrowedBookList.Items.Add(item);
            }

            foreach (var item in selectedItems)
            {
                BooksList.Items.Remove(item);
            }
        }

        private void GiveBackButton_Click(object sender, EventArgs e)
        {
            if (BorrowedBookList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select Returned Book or Books.");
            }

            var selectedItems = BorrowedBookList.SelectedItems.Cast<object>().ToList();

            foreach (var item in selectedItems)
            {
                BooksList.Items.Add(item);
            }

            foreach (var item in selectedItems)
            {
                BorrowedBookList.Items.Remove(item);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string text = BookNameToAddTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a book name.");
                return;
            }
            else if (BooksList.Items.Contains(text))
            {
                MessageBox.Show("This book already exists in the library.");
                return;
            }
            else
            {
                BooksList.Items.Add(text);
            }
        }

        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            string text = BookNameToRemoveTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a book name to remove.");
                return;
            }
            else if (!BooksList.Items.Contains(text))
            {
                MessageBox.Show("This book does not exist in the library.");
                return;
            }
            else
            {
                BooksList.Items.Remove(text);
                MessageBox.Show("Book removed successfully.");
            }
        }
    }
}
