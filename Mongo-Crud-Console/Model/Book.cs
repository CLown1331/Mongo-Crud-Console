using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo_Crud_Console.Model
{
    public class Book: EntityBase
    {
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
