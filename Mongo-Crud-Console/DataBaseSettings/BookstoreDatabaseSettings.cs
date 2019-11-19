using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo_Crud_Console.DataBaseSettings
{
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
