using System.ComponentModel.DataAnnotations;
using Compelover.Core.Entities;

namespace Compelover.Entities.Tangible
{
    public class BlogCategory : IEntity
    {
        public string Id { get; set; }
        public Blog Blog { get; set; }
        public string BlogId { get; set; }
        public Category Category { get; set; }
        public string CategoryId { get; set; }

    }
}