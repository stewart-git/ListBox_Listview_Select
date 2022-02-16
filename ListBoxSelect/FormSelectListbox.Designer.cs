namespace ListBoxSelect
{
    partial class FormSelectListbox
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelListBox = new System.Windows.Forms.Label();
            this.labelListView = new System.Windows.Forms.Label();
            this.labelTextBoxName = new System.Windows.Forms.Label();
            this.labelTextBoxSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(13, 32);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(134, 160);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(163, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(163, 110);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 2;
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSalary});
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(284, 32);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(145, 157);
            this.listViewItems.TabIndex = 3;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewItems_MouseClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderSalary
            // 
            this.columnHeaderSalary.Text = "Salary";
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Location = new System.Drawing.Point(10, 16);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(44, 13);
            this.labelListBox.TabIndex = 4;
            this.labelListBox.Text = "List Box";
            // 
            // labelListView
            // 
            this.labelListView.AutoSize = true;
            this.labelListView.Location = new System.Drawing.Point(281, 16);
            this.labelListView.Name = "labelListView";
            this.labelListView.Size = new System.Drawing.Size(49, 13);
            this.labelListView.TabIndex = 5;
            this.labelListView.Text = "List View";
            // 
            // labelTextBoxName
            // 
            this.labelTextBoxName.AutoSize = true;
            this.labelTextBoxName.Location = new System.Drawing.Point(160, 55);
            this.labelTextBoxName.Name = "labelTextBoxName";
            this.labelTextBoxName.Size = new System.Drawing.Size(80, 13);
            this.labelTextBoxName.TabIndex = 6;
            this.labelTextBoxName.Text = "Text Box Name";
            // 
            // labelTextBoxSalary
            // 
            this.labelTextBoxSalary.AutoSize = true;
            this.labelTextBoxSalary.Location = new System.Drawing.Point(160, 94);
            this.labelTextBoxSalary.Name = "labelTextBoxSalary";
            this.labelTextBoxSalary.Size = new System.Drawing.Size(81, 13);
            this.labelTextBoxSalary.TabIndex = 7;
            this.labelTextBoxSalary.Text = "Text Box Salary";
            // 
            // FormSelectListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 207);
            this.Controls.Add(this.labelTextBoxSalary);
            this.Controls.Add(this.labelTextBoxName);
            this.Controls.Add(this.labelListView);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxItems);
            this.Name = "FormSelectListbox";
            this.Text = "Select Listbox Item";
            this.Load += new System.EventHandler(this.FormSelectListbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Label labelListBox;
        private System.Windows.Forms.Label labelListView;
        private System.Windows.Forms.Label labelTextBoxName;
        private System.Windows.Forms.Label labelTextBoxSalary;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSalary;
    }
}

