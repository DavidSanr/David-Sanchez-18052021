using BertoniAppDavid.BLL.Models.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniAppDavid.Services.Services
{
    public interface IAlbumServices
    {
        Task<List<AlbumViewModel>> GetAll();
    }
}