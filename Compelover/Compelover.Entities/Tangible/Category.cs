using System.Collections.Generic;
using Compelover.Core.Entities;

namespace Compelover.Entities.Tangible
{
    public class Category : IEntity
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
    }
}