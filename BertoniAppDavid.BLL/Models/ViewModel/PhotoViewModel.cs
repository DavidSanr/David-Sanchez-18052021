using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniAppDavid.BLL.Models.ViewModel
{
   public class PhotoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
