using BertoniAppDavid.BLL.Models.ViewModel;
using BertoniAppDavid.DAL.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAppDavid.Services.Services
{
    public class CommentsService : ICommentsService
    {
        private IDataApi _dataApi;

        public CommentsService(IDataApi dataApi)
        {
            _dataApi = dataApi;
        }

        public async Task<List<CommentViewModel>> GetCommentsByPhotoId(int photoId)
        {
            var response = await _dataApi.GetCommentsByPhotoId(photoId);
            var comments = response.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Body = x.Body
            }).ToList();

            return comments;
        }
    }
}
