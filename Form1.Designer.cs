namespace library_automation
{
    partial class Form1
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
            BorrowBookButton = new Button();
            BooksList = new ListBox();
            BookNameToAddTextBox = new TextBox();
            AddBookButton = new Button();
            GiveBackButton = new Button();
            BorrowedBookList = new ListBox();
            BookNameToRemoveTextBox = new TextBox();
            RemoveBookButton = new Button();
            SuspendLayout();
            // 
            // BorrowBookButton
            // 
            BorrowBookButton.Location = new Point(12, 185);
            BorrowBookButton.Name = "BorrowBookButton";
            BorrowBookButton.Size = new Size(103, 23);
            BorrowBookButton.TabIndex = 0;
            BorrowBookButton.Text = "Borrow a book";
            BorrowBookButton.UseVisualStyleBackColor = true;
            BorrowBookButton.Click += BorrowBookButton_Click;
            // 
            // BooksList
            // 
            BooksList.Cursor = Cursors.IBeam;
            BooksList.FormattingEnabled = true;
            BooksList.Location = new Point(12, 12);
            BooksList.Name = "BooksList";
            BooksList.Size = new Size(220, 169);
            BooksList.TabIndex = 2;
            // 
            // BookNameToAddTextBox
            // 
            BookNameToAddTextBox.Location = new Point(610, 12);
            BookNameToAddTextBox.Name = "BookNameToAddTextBox";
            BookNameToAddTextBox.Size = new Size(178, 23);
            BookNameToAddTextBox.TabIndex = 3;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(610, 41);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(178, 23);
            AddBookButton.TabIndex = 4;
            AddBookButton.Text = "Add book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // GiveBackButton
            // 
            GiveBackButton.Location = new Point(121, 185);
            GiveBackButton.Name = "GiveBackButton";
            GiveBackButton.Size = new Size(111, 23);
            GiveBackButton.TabIndex = 5;
            GiveBackButton.Text = "Give back";
            GiveBackButton.UseVisualStyleBackColor = true;
            GiveBackButton.Click += GiveBackButton_Click;
            // 
            // BorrowedBookList
            // 
            BorrowedBookList.Cursor = Cursors.IBeam;
            BorrowedBookList.FormattingEnabled = true;
            BorrowedBookList.Location = new Point(12, 214);
            BorrowedBookList.Name = "BorrowedBookList";
            BorrowedBookList.Size = new Size(220, 229);
            BorrowedBookList.TabIndex = 6;
            // 
            // BookNameToRemoveTextBox
            // 
            BookNameToRemoveTextBox.Location = new Point(610, 386);
            BookNameToRemoveTextBox.Name = "BookNameToRemoveTextBox";
            BookNameToRemoveTextBox.Size = new Size(178, 23);
            BookNameToRemoveTextBox.TabIndex = 7;
            // 
            // RemoveBookButton
            // 
            RemoveBookButton.Location = new Point(610, 415);
            RemoveBookButton.Name = "RemoveBookButton";
            RemoveBookButton.Size = new Size(178, 23);
            RemoveBookButton.TabIndex = 8;
            RemoveBookButton.Text = "Remove book";
            RemoveBookButton.UseVisualStyleBackColor = true;
            RemoveBookButton.Click += RemoveBookButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBookButton);
            Controls.Add(BookNameToRemoveTextBox);
            Controls.Add(BorrowedBookList);
            Controls.Add(GiveBackButton);
            Controls.Add(AddBookButton);
            Controls.Add(BookNameToAddTextBox);
            Controls.Add(BooksList);
            Controls.Add(BorrowBookButton);
            Name = "Form1";
            Text = "Library Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BorrowBookButton;
        private ListBox BooksList;
        private TextBox BookNameToAddTextBox;
        private Button AddBookButton;
        private Button GiveBackButton;
        private ListBox BorrowedBookList;
        private TextBox BookNameToRemoveTextBox;
        private Button RemoveBookButton;
    }
}
