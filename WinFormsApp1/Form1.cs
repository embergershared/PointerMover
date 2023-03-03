namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person[] list = new Person[] {
                    new Person(1, "Jon", "M"),
                    new Person(2, "Ram", "M"),
                    new Person(3, "Rin", "F"),
                    new Person(4, "Sue", "F"),
                    new Person(5, "Ken", "M"),
                    new Person(6, "Tom", "M"),
                    new Person(7, "Sam", "M")
                };
                comBox_FilledWithArray.DataSource = list;
                comBox_FilledWithArray.DisplayMember = "Name";
                comBox_FilledWithArray.ValueMember = "Gender";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}