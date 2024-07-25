using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICETask1
{
    public class Books
    {
        double bookID;
        string bookTitle, bookAuthor;
        double price;
        public Books(double bookID, string bookTitle, string bookAuthor, double price)
        {
            this.bookID = bookID;
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.price = price;
        }

        public object this[int index]
            {
                get
                {
                    if (index == 0)
                        return this.bookID;

                    else if (index == 1)
                        return this.bookTitle;

                    else if (index == 2)
                        return this.bookAuthor;

                    else if (index == 3)
                        return this.price;
                    return null;
                }

                
                set
                {
                    if (index == 0)
                        this.bookID = (double)value;

                    else if (index == 1)
                        this.bookTitle = (string)value;

                    else if (index == 2)
                        this.bookAuthor = (string)value;

                    else if (index == 3)
                        this.price = (double)value;
                }
            }

        public object this[string attributes]
        {
            get
            {
                if (attributes.ToLower().Equals("bookID"))
                    return this.bookID;
                else if (attributes.ToLower().Equals("bookTitle"))
                    return this.bookTitle;
                else if (attributes.ToLower().Equals("bookAuthor"))
                    return this.bookAuthor;
                else if (attributes.ToLower().Equals("price"))
                    return this.price;
                return null;
            }

            set
            {
                if (attributes.ToLower().Equals("bookID"))
                    this.bookID = (double)value;

                else if (attributes.ToLower().Equals("bookTitle"))
                    this.bookTitle = (string)value;

                else if (attributes.ToLower().Equals("bookAuthor"))
                    this.bookAuthor = (string)value;

                else if (attributes.ToLower().Equals("price"))
                    this.price = (double)value;

            }
        }


    }
}

    

