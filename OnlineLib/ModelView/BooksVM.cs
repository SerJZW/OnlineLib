using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OnlineLib.ModelView
{
    class BooksVM : Notice
    {
        private Books books;

        public BooksVM(Books b)
        {
            books = b;
        }
        public string? Autor
        {
            get { return books.Autor; }
            set { books.Autor = value; OnPropertyChanged("Autor"); }
        }
        public short Acr
        {
            get { return books.Acr; }
            set { books.Acr = value; OnPropertyChanged("Acr"); }
        }
        public DateOnly Age
        {
            get { return books.Age; }
            set { books.Age = value; OnPropertyChanged("Age"); }
        }
        public int Count
        {
            get { return books.Count; }
            set { books.Count = value; OnPropertyChanged("Count"); }
        }
    }
}
