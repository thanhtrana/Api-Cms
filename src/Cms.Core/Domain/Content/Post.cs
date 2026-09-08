using System;
using System.Collections.Generic;
using System.Text;

namespace Cms.Core.Domain.Content
{
    [Table("Posts")]
    public class Post
    {
        [Key]
       public Guid Id {get; set;}
       public string Name {get; set;}
       public string Slug{ get; set;}
       public string Description {get; set;}
       public Guid CategoryId {get; set;}
       public string Content {get; set;}
       public Guid AuthorUserId {get; set;}
       public string Thumbnail {get; set;}
       public string Source {get; set;}
       public string SeoDescription {get; set;}
       public int ViewCount {get; set;}
       public int LikeCount {get; set;}
       public int CommentCount {get; set;}
       public int ShareCount {get; set;}
       public int Status {get; set;}
       public bool IsPaid {get; set;}
       public decimal RoyaltyMoney {get; set;}
       public Guid CreatedBy {get; set;}
       public DateTime CreatedDate {get; set;}
       public Guid UpdatedBy {get; set;}
       public DateTime UpdatedDate {get; set;}
    }

    public class PostStatus
    {
        const int Draft = 1;
        const int Canceled = 2;
        const int WaitingForApproval = 3;
        const int Rejected = 4;
        const int WaitingForPublish = 5;
        const int Published = 6;
    }
}
