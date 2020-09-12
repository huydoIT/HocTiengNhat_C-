using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengNhat
{
    public partial class usAddLesson : UserControl
    {
        private static usAddLesson _instance;
        public MyUser userInfo { get; set; }

        public static usAddLesson Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new usAddLesson();     
                }
                return _instance;
            }
        }
        public usAddLesson()
        {
            InitializeComponent();
        }

        public usAddLesson(MyUser user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button pressed!!");
        }

        private void usAddLesson_Load(object sender, EventArgs e)
        {
            this.lbLesson.Text = "Lesson " + (int.Parse(userInfo.numOfPart) + 1).ToString();
        }
    }
}
