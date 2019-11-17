using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo_Crud_Console.Model
{
    public abstract class EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public BsonDateTime CreateDate;

        public BsonDateTime LastModifiedDate;
    }
}
