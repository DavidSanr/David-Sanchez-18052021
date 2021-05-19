using BertoniAppDavid.BLL.Models.ViewModel;
using BertoniAppDavid.DAL.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAppDavid.Services.Services
{
    public class PhotoService : IPhotoService
    {
        private IDataApi _dataApi;
        private ICommentsService _commentsService;

        public PhotoService(IDataApi dataApi, ICommentsService commentsService)
        {
            _dataApi = dataApi;
            _commentsService = commentsService;
        }

        public async Task<List<PhotoViewModel>> GetPhotosByAlbumId(int albumId)
        {
            var response = await _dataApi.GetPhotosByAlbumId(albumId);
            var photos = response.Select(x => new PhotoViewModel
            {
                Id = x.Id,
                ThumbnailUrl = x.ThumbnailUrl,
                Title = x.Title,
                Comments = x.Comments.Select(y => new CommentViewModel
                {
                    Id = y.Id,
                    Body = y.Body,
                    Name = y.Name
                }).ToList()
            }).ToList();

            return photos;
        }
        public async Task<PhotoViewModel> GetPhotoById(int photoId)
        {
            var response = await _dataApi.GetPhotoById(photoId);
            var comments = await _commentsService.GetCommentsByPhotoId(photoId);

            PhotoViewModel photo = new PhotoViewModel()
            {
                Id = response.Id,
                Title = response.Title,
                Url = response.Url,
                Comments = comments ?? comments
            };

            return photo;
        }
    }
}
