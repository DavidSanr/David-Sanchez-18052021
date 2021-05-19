using BertoniAppDavid.BLL.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniAppDavid.BLL.Models.ViewModel
{
    public class AlbumViewModel : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
