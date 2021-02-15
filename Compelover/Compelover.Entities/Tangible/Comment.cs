using System;
using System.Collections.Generic;
using Compelover.Core.Entities;

namespace Compelover.Entities.Tangible
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public int? ParentCommentInd { get; set; }
        public string CommentDescription { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public DateTime CommentPostedTime { get; set; } = DateTime.Now;
        // public Comment ParentComment { get; set; }
        // public List<Comment> BottomComments { get; set; }
        // public Blog Blog { get; set; }
        // public List<AppUser> AppUsers { get; set; }
        // public AppUser AppUser { get; set; }
    }
}