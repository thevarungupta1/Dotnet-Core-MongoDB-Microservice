using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WebApplication4.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string  Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
