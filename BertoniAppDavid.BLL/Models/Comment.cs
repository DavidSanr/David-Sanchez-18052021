﻿using BertoniAppDavid.BLL.Models.Interface;

namespace BertoniAppDavid.BLL.Models
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}