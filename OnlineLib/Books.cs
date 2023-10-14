using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLib
{
    public class Books
    {
        public string? Autor { get; set; }
        public short Acr { get; set; }
        public DateOnly Age { get; set; }
        public int Count { get; set; }
        public Books(string autor, short acr, DateOnly age, int count) 
        {
            Autor = autor;
            Acr = acr;
            Age = age;
            Count = count;
        }
    }
}
