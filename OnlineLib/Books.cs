using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLib
{
    class Books
    {
        public string Autor;
        public string Arc;
        public DateTime Age;
        public int Count;
        public Books(string autor, string arc, DateTime age, int count) 
        {
            Autor = autor;
            Arc = arc;
            Age = age;
            Count = count;
        }
    }
}
