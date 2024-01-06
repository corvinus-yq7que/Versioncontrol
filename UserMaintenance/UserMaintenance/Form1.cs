using System.ComponentModel;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            lblLastName.Text = Resource1.LastName;
            lblFirstName.Text = Resource1.FirstName;

            btnAdd.Text = Resource1.FirstName;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "Fullname";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };
            users.Add(u);
        }
    }
}