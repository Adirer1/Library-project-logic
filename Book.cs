using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project_logic
{
    public class Book : Item
    {
       /* public Book(string author,string title, string genre, string publisher, DateOnly publishDate, double price) : 
            base(title, genre, publisher, publishDate, price)
            {
            Author = author;
            }*/


        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
    }
}
