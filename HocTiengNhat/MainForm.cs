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
        // Test Github
        public MyUser userInfo { get; set; }
        IFirebaseClient client;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(MyUser user)
        {       
            InitializeComponent();
            userInfo = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new DataConnect().getClient();
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

            if (!panelDetail.Controls.Contains(ucLesson.Instance))
            {
                ucLesson frm = new ucLesson(partInfo);
                //panelDetail.Controls.Add(usAddLesson.Instance);
                //usAddLesson.Instance.Dock = DockStyle.Fill;
                //usAddLesson.Instance.BringToFront();
                panelDetail.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
            }
            else
            {
                ucLessonAdd.Instance.BringToFront();
            }

            //MessageBox.Show(userInfo.user + "_" + curButton.Name.Substring(4));
        }

        public void btnAddClick(object sender, EventArgs e)
        {
            //Button curButton = (Button)sender;
            //dataGridView1.Rows.Clear();

            //MessageBox.Show("Add button pressed!!");
            if (!panelDetail.Controls.Contains(ucLessonAdd.Instance))
            {
                ucLessonAdd frm = new ucLessonAdd(userInfo);
                //panelDetail.Controls.Add(usAddLesson.Instance);
                //usAddLesson.Instance.Dock = DockStyle.Fill;
                //usAddLesson.Instance.BringToFront();
                panelDetail.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
            }
            else
            {
                ucLessonAdd.Instance.BringToFront();
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
            b.Margin = new Padding(5);

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
