using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Book
    {
        private string bookid;
        private string bookName;
        private string bookAuthor;
        private string bookEdition;

      
        public string Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public string BookEdition
        {
            get { return bookEdition; }
            set { bookEdition = value; }
        }
    }
}
