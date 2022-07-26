using MongoDB.Driver;
using MVCCore.MongoDB.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.MongoDB.CRUD.Repositories
{
    public class AlbumCollection : IAlbumCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository();
        private IMongoCollection<Album> Collection;
    
        public AlbumCollection()
        {
            Collection = _repository.db.GetCollection<Album>("Albums");
        }

        public void DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Album GetAlbumById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAllAlbums()
        {
            throw new NotImplementedException();
        }

        public void InsertAlbum(Album album)
        {
            Collection.InsertOneAsync(album);
        }

        public void UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
