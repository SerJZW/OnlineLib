using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineLib.ModelView
{
    class UsersVM : Notice
    {
        private Users users;
        UsersVM(Users u) 
        {
            users = u;
        }
        public int ID
        {
            get { return users.ID; }
            set { users.ID = value; OnPropertyChanged("ID"); }
        }
        public string? Name
        {
            get { return users.Name; }
            set { users.Name = value; OnPropertyChanged("Name"); }
        }
        public string? Family
        {
            get { return users.Family; }
            set { users.Family = value; OnPropertyChanged("Family"); }
        }
        public List<Books>? UserBooks
        {
            get { return users.UserBooks; }
            set { users.UserBooks = value; OnPropertyChanged("UserBooks"); }
        }

    }
}
