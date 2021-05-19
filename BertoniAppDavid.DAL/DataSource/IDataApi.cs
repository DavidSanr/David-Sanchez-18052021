using BertoniAppDavid.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniAppDavid.DAL.DataSource
{
    public interface IDataApi
    {
        Task<List<Album>> GetAllAlbums();
        Task<List<Comment>> GetCommentsByPhotoId(int photoId);
        Task<Photo> GetPhotoById(int photoId);
        Task<List<Photo>> GetPhotosByAlbumId(int albumId);
    }
}