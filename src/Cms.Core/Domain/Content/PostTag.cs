using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Content
{
    [Table("PostTags")]
    [Index(nameof(PostId), IsUnique = false)]
    [Index(nameof(TagId), IsUnique = false)]
    public class PostTag
    {
        [Key]
        public long Id { get; set; }
        public long PostId { get; set; }
        public long TagId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
