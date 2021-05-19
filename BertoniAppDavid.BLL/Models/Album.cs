using BertoniAppDavid.BLL.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniAppDavid.BLL.Models
{
    public class Album : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public virtual List<Photo> Photos { get; set; }

    }
}
