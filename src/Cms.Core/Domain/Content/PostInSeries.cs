using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Content
{
    [Table("PostInSeries")]
    [Index(nameof(SeriesId), IsUnique = false)]
    [Index(nameof(PostId), IsUnique = false)]
    public class PostInSeries
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SeriesId { get; set; }
        public Guid PostId { get; set; }
        public int DisplayOrder { get; set; }
        public int SortOrder { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
