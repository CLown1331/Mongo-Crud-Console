using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo_Crud_Console.DataBaseSettings
{
    public interface IBookstoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
