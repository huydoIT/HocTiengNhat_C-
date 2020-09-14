using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace HocTiengNhat
{
    public partial class ucLesson : UserControl
    {
        private static ucLesson _instance;

        public MyUser userInfo { get; set; }
        string partInfo;
        public static ucLesson Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucLesson();
                }
                return _instance;
            }
        }

        IFirebaseClient client = new DataConnect().getClient();
        
        public ucLesson(MyUser user)
        {
            InitializeComponent();
            userInfo = user;
        }
        public ucLesson(string _partInfo)
        {
            InitializeComponent();
            partInfo = _partInfo;
        }

        public ucLesson()
        {
            InitializeComponent();
        }

        public void dataLoad()
        {
            FirebaseResponse resNumOf = client.Get(@"partInfo/" + partInfo + "/numOfVal");


            //MessageBox.Show("Result: " + resNumOf.ResultAs<string>());
            int numberOf = int.Parse(resNumOf.ResultAs<string>());
            int lessonNum = int.Parse(partInfo.Substring(partInfo.IndexOf("_") + 1)) + 1;

            this.lbLesson.Text = "Lesson " + lessonNum.ToString();
            this.lbNum.Text = "Vocabulary: " + numberOf.ToString();

            for (int i = 1; i <= numberOf; i++)
            {
                FirebaseResponse resData = client.Get(@"partInfo/" + partInfo + "/detail/" + i);
                MyDetail resDetail = resData.ResultAs<MyDetail>();

                if (resDetail != null)
                {
                    dgvData.Rows.Add(resDetail.kanji, resDetail.hira, resDetail.mean);
                }
            }
        }

        private void ucLesson_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
    }
}
