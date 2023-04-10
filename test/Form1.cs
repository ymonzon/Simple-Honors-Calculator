using System.Security.Cryptography;

namespace test
{
    public partial class Assignment1 : Form
    {
        public Assignment1()
        {
            InitializeComponent();
        }

        private void Assignment1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyy");
        }

        private void btnHonors_Click_1(object sender, EventArgs e)
        {
            double gpa;

            try
            {
                gpa = Convert.ToSingle(txtGPA.Text);
                lblMessage.Text = "";

                if (gpa <= 0 || gpa > 4)
                {
                    MessageBox.Show("Please enter a valid GPA", "Invalid GPA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gpa >= 3.75)
                {
                    lblMessage.Text = "HONORS STUDENT";
                    MessageBox.Show("Congratulations " + txtFirstName.Text.ToUpper() + "!! You will graduate with honors.",
                        "HONORS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Sorry - No honors for you - better luck next time", "No Honors");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}