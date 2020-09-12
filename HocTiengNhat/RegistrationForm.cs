using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace HocTiengNhat
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "DGf5cJ8AcEYEVYMuxDA12NOli8Vk1Tm1s0lXIiz5",
            BasePath = "https://fir-d5946.firebaseio.com/"
        };

        IFirebaseClient client;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Connection have problem");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();

            this.Close(); 
            if (frm.Visible == false)
            {
                frm.Show();
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            #region Condition check
            if (string.IsNullOrWhiteSpace(txtUser.Text) &&
                string.IsNullOrWhiteSpace(txtPass.Text) &&
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please input all fields");
                return;
            }
            #endregion
            FirebaseResponse getId = client.Get(@"Counter");
            int cnt = int.Parse(getId.ResultAs<string>()) + 1;
            MyUser user = new MyUser()
            {
                user = txtUser.Text,
                pass = txtPass.Text,
                name = txtName.Text,
                id = cnt.ToString(),
                numOfPart = "0"
            };

            SetResponse setUser = client.Set(@"Users/" + txtUser.Text, user);
            SetResponse setId = client.Set(@"Counter", cnt.ToString());
            MessageBox.Show("Registration Successfully !!");

        }

    }
}
