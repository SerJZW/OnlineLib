using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLib
{
   public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public List<Books> Books { get; set; }
        public Users(int id, string name, string family, List<Books> books) 
        {
            Id = id;
            Name = name;
            Family = family;
            Books = books;
        }

    }
    
}
