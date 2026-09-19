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
        public long Id { get; set; }
        public long SeriesId { get; set; }
        public long PostId { get; set; }
        public int DisplayOrder { get; set; }
        public int SortOrder { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
