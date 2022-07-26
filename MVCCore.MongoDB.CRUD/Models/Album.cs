using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.MongoDB.CRUD.Models
{
    public class Album
    {
        [BsonId]
        public int ObjectId { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }

    }
}
