using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Content
{
    [Table("PostActivityLogs")]
    public class PostActivityLog
    {
        [Key]
        public long Id { get; set; }
        public long PostId { get; set; }
        public long UserId { get; set; }
        public PostStatus FromStatus { get; set; }
        public PostStatus ToStatus { get; set; }
        public string ActivityType { get; set; }
        public string ActivityData { get; set; }
        public DateTime DateCreate { get; set; }
        public string? Note { get; set; }
        public DateTime ActivityDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}
