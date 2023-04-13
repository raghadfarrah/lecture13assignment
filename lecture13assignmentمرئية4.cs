namespace lecture13assignmentمرئية4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar))
            { e.Handled = true;}
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void btnsubment_Click(object sender, EventArgs e)
        {
            string name;
            int age;

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = txtName.Text;
                age = int.Parse(txtAge.Text);
                MessageBox.Show("Name: " + name + "\n" + "Age: " + age.ToString());
            }
        }
    }
}