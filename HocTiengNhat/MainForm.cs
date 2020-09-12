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
using System.Windows;
using MessageBox = System.Windows.MessageBox;

namespace HocTiengNhat
{
    public partial class MainForm : Form
    {
        public MyUser userInfo { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(MyUser user)
        {       
            InitializeComponent();
            userInfo = user;
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "DGf5cJ8AcEYEVYMuxDA12NOli8Vk1Tm1s0lXIiz5",
            BasePath = "https://fir-d5946.firebaseio.com/"
        };
        IFirebaseClient client;
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Connection have problem");
            }
            this.lbName.Text = "Hello " + userInfo.name;
            //MessageBox.Show(userInfo.numOfPart);
            if(int.Parse(userInfo.numOfPart) == 0)
            {
                Button btn = creatButtons(-1);
                this.panelData.Controls.Add(btn);
                btn.Click += new EventHandler(btnAddClick);
            }
            else
            {
                for (int i = 0; i < int.Parse(userInfo.numOfPart); i++)
                {
                    Button btn = creatButtons(i);
                    this.panelData.Controls.Add(btn);
                    btn.Click += new EventHandler(btnLessonClick);
                }
                Button btn2 = creatButtons(-1);
                this.panelData.Controls.Add(btn2);
                btn2.Click += new EventHandler(btnAddClick);
            }
            
            //this.lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        }

        public void btnLessonClick(object sender, EventArgs e)
        {
            Button curButton = (Button)sender;
            //usAddLesson.Instance.Hide();
            dataGridView1.Rows.Clear();
            //get partID
            string partInfo = userInfo.user + "_" + curButton.Name.Substring(4);
            //MessageBox.Show("part info: " + partInfo);
            FirebaseResponse resNumOf = client.Get(@"partInfo/" + partInfo + "/numOfVal");


            //MessageBox.Show("Result: " + resNumOf.ResultAs<string>());
            int numberOf = int.Parse(resNumOf.ResultAs<string>());
            this.lbLesson.Text = curButton.Text;
            this.lbNum.Text = "Vocabulary: " + numberOf.ToString();
            for(int i = 1; i <= numberOf; i++)
            {
                FirebaseResponse resData = client.Get(@"partInfo/" + partInfo + "/detail/" + i);
                MyDetail resDetail = resData.ResultAs<MyDetail>();

                if(resDetail != null)
                {
                    dataGridView1.Rows.Add(resDetail.kanji, resDetail.hira, resDetail.mean);
                }
            }
            //MessageBox.Show(userInfo.user + "_" + curButton.Name.Substring(4));
        }

        public void btnAddClick(object sender, EventArgs e)
        {
            //Button curButton = (Button)sender;
            //dataGridView1.Rows.Clear();

            //MessageBox.Show("Add button pressed!!");
            if (!panelDetail.Controls.Contains(usAddLesson.Instance))
            {
                usAddLesson frm = new usAddLesson(userInfo);
                //panelDetail.Controls.Add(usAddLesson.Instance);
                //usAddLesson.Instance.Dock = DockStyle.Fill;
                //usAddLesson.Instance.BringToFront();
                panelDetail.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
            }
            else
            {
                usAddLesson.Instance.BringToFront();
            }
        }

        Button creatButtons(int controlNumber)
        {
            Button b = new Button();
            b.ForeColor = Color.White;
            b.BackColor = Color.Green;
            //b.Location = new Point(startPos, endPos);
            b.Height = 50;
            b.Width = 150;
            b.Margin = new Padding(3);

            if (controlNumber == -1)
            {
                b.Name = "btnAdd";
                b.Text = "New";
            }
            else {
                string num = controlNumber < 10 ? "0" + controlNumber.ToString() : controlNumber.ToString();
                b.Name = "btn_" + num;
                b.Text = "Lesson " + (controlNumber + 1).ToString();
            }
            
            return b;
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm frm = new LoginForm();
            if(frm.Visible == false)
            {
                frm.Show();
            }
        }
    }
}
