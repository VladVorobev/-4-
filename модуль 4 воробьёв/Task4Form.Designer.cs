namespace модуль_4_воробьёв
{
    partial class Task4Form
    {
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Button btnIssueBook;

        private void InitializeComponent()
        {
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(12, 12);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(200, 160);
            this.listBoxBooks.TabIndex = 0;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.BackColor = System.Drawing.Color.Green;
            this.btnCheckAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAvailability.FlatAppearance.BorderSize = 0;
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btnCheckAvailability.Location = new System.Drawing.Point(15, 178);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(200, 40);
            this.btnCheckAvailability.TabIndex = 1;
            this.btnCheckAvailability.Text = "Проверить доступность";
            this.btnCheckAvailability.UseVisualStyleBackColor = false;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.Red;
            this.btnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(15, 224);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(200, 39);
            this.btnIssueBook.TabIndex = 2;
            this.btnIssueBook.Text = "Выдать книгу";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // Task4Form
            // 
            this.BackgroundImage = global::модуль_4_воробьёв.Properties.Resources.fon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(227, 267);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.btnIssueBook);
            this.Name = "Task4Form";
            this.Text = "Библиотека";
            this.ResumeLayout(false);

        }
    }
}
