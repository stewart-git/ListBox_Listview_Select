using System.Drawing;
using System.Windows.Forms;
// two methods for displaying arrays
// method one uses a List Box
// method two uses a List View
// ListView: display as "Details"
// and Add column text
namespace ListBoxSelect
{
    public partial class FormSelectListbox : Form
    {
        public FormSelectListbox()
        {
            InitializeComponent();
        }
        // declare and fill two arrays of size seven
        string[] arrayName = new string[] {"Red", "Orange", "Yellow", "Green", "Blue", "Indego", "Violet" };
        int[] arraySalary = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        
        //================ LIST BOX ================================
        // select item in List Box and display in Text Box
        private void listBoxItems_MouseClick(object sender, MouseEventArgs e)
        {
            // select a record in the Listbox
            string curItem = listBoxItems.SelectedItem.ToString();
            // find the index of the selected item
            int indx = listBoxItems.FindString(curItem);
            // put the Listbox item into the textbox
            textBoxName.Text = arrayName[indx];
            // convert integer into string
            textBoxSalary.Text = arraySalary[indx].ToString();
            // pass parameter value (integer) to method
            ChangeTextBoxColour(indx);
        }
        // display arrays in List Box
        private void DisplayArraysListBox()
        {
            // clear the list box
            listBoxItems.Items.Clear();
            for (int i = 0; i < arrayName.Length; i++)
            {
                // add items to Listbox - use a tab to seperate items
                listBoxItems.Items.Add(arrayName[i] + "\t" + arraySalary[i]);
            }
        }

        //================= LIST VIEW ================================
        // select item in List View and display in Text Box
        private void listViewItems_MouseClick(object sender, MouseEventArgs e)
        {
            int currentItem = listViewItems.SelectedIndices[0];
            // put the selected List View item into the textbox
            textBoxName.Text = arrayName[currentItem];
            // convert integer into string
            textBoxSalary.Text = arraySalary[currentItem].ToString();
            // pass parameter value (integer) to method
            ChangeTextBoxColour(currentItem);
        }
        // display arrays in List View
        private void DisplayArraysListView()
        {
            listViewItems.Items.Clear();
            for (int i = 0; i < arrayName.Length; i++)
            {
                // create a list view item with the first array
                ListViewItem lvi = new ListViewItem(arrayName[i]);
                // add the next list view item from the second array
                lvi.SubItems.Add(arraySalary[i].ToString());
                // add the list view items to the List View
                listViewItems.Items.Add(lvi);
            }
        }
        //==================================================
        // method to change text box colours 
        // receives paramater from method call (integer)
        private void ChangeTextBoxColour(int colour)
        {
            textBoxName.ForeColor = Color.Black;
            switch (colour)
            {
                case 0: textBoxName.BackColor = Color.Red; break;
                case 1: textBoxName.BackColor = Color.Orange; break;
                case 2: textBoxName.BackColor = Color.Yellow; break;
                case 3: textBoxName.BackColor = Color.Green; break;
                case 4: textBoxName.BackColor = Color.Blue;
                        textBoxName.ForeColor = Color.White; break;
                case 5: textBoxName.BackColor = Color.Indigo;
                        textBoxName.ForeColor = Color.White; break;
                case 6: textBoxName.BackColor = Color.Violet; break;
            }
        }

        private void FormSelectListbox_Load(object sender, System.EventArgs e)
        {
            // display the arrays in the List Box when the form is opened
            DisplayArraysListBox();
            // display the arrays in the List View when the form is opened
            DisplayArraysListView();
        }
    }
}
