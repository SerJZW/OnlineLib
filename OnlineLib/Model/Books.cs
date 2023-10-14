using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLib
{
    public class Books : Notice
    {
        private string? autor;
        private short acr;
        private DateOnly age;
        private int count;
        public string? Autor
        {
            get { return autor; }
            set { autor = value; OnPropertyChanged("Autor"); }
        }
        public short Acr
        {
            get { return acr; }
            set { acr = value; OnPropertyChanged("Acr"); }
        }
        public DateOnly Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }
        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged("Count"); }
        }
    }
}
