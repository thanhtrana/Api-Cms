using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Content
{
    [Index(nameof(Slug), IsUnique = true)]
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool Active { get; set; }
        public long? ParentId { get; set; }
        public int SortOrder { get; set; }
        public string? SeoKeywords { get; set; }
        public string? SeoDescription { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
