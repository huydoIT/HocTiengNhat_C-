using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengNhat
{
    public class MyUser
    {
        public MyUser()
        {
        }

        public MyUser(string _id, string _numofpart, string _user, string _pass, string _name)
        {
            id = _id;
            numOfPart = _numofpart;
            user = _user;
            pass = _pass;
            name = _name;
        }
        public string id { get; set; }

        public string numOfPart { get; set; }

        public string user { get; set; }

        public string pass { get; set; }

        public string name { get; set; }

        private static string error = "These have some error!";

        public static void showError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool loginCheck(MyUser u1, MyUser u2)
        {
            if (u1 == null || u2 == null)
            {
                return false;
            }
            if (u1.user.Equals(u2.user) == false)
            {
                error = "Username not exits!";
                return false;
            }
            else if (u1.pass.Equals(u2.pass) == false)
            {
                error = "Password incorrect";
                return false;
            }

            return true;
        }
    }
}
