using BertoniAppDavid.BLL.Models.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniAppDavid.Services.Services
{
    public interface IPhotoService
    {
        Task<PhotoViewModel> GetPhotoById(int photoId);
        Task<List<PhotoViewModel>> GetPhotosByAlbumId(int albumId);
    }
}