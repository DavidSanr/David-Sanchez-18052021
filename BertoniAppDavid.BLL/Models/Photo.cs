using BertoniAppDavid.BLL.Models.Interface;
using System.Collections.Generic;

namespace BertoniAppDavid.BLL.Models
{
    public class Photo: IEntity
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }

        public virtual List<Comment> Comments { get; set; }


    }
}