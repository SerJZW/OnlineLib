using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLib
{
    public class Users : Notice
    {
        private int id;
        private string? name;
        private string? family;
        private List<Books>? userBooks;

        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("ID"); } }
        public string? Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        public string? Family
        {
            get { return family; }
            set { family = value; OnPropertyChanged("Family"); }
        }
        public List<Books>? UserBooks
        {
            get { return userBooks; }
            set { userBooks = value; OnPropertyChanged("UserBooks"); }
        }
    }
}
    

