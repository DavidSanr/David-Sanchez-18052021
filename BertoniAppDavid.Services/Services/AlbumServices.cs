using BertoniAppDavid.BLL.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BertoniAppDavid.DAL.DataSource;
using System.Linq;
using BertoniAppDavid.BLL.Models.Interface;

namespace BertoniAppDavid.Services.Services
{
    public class AlbumServices : IAlbumServices
    {
        private IDataApi _dataApi;

        public AlbumServices(IDataApi dataApi)
        {
            _dataApi = dataApi;
        }

        public async Task<List<AlbumViewModel>> GetAll()
        {
            var response = await _dataApi.GetAllAlbums();
            var albums = response.Select(x => new AlbumViewModel
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();

            return albums;
        }

    }
}
