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
using FireSharp.Response;
using FireSharp.Interfaces;


namespace HocTiengNhat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "DGf5cJ8AcEYEVYMuxDA12NOli8Vk1Tm1s0lXIiz5",
            BasePath = "https://fir-d5946.firebaseio.com/"
        };

        IFirebaseClient client;

        private void BtnReg_Click(object sender, EventArgs e)
        {           
            RegistrationForm frm = new RegistrationForm();
            this.Hide();
            frm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            #region Condition check
            if (string.IsNullOrWhiteSpace(txtUser.Text) &&
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please Input Username and Password");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Users/" + txtUser.Text);
            MyUser resUser = res.ResultAs<MyUser>();

            MyUser curUser = new MyUser()
            {
                user = txtUser.Text,
                pass = txtPass.Text
            };

            if (MyUser.loginCheck(resUser, curUser) == true)
            {
                //MessageBox.Show("Login Successed!!");
                MainForm mainform = new MainForm(resUser);
                this.Hide();
                mainform.Show();
            }
            else
            {
                MyUser.showError();
            }
        }
    }
}
