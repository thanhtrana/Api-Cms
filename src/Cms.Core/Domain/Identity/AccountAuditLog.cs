using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("AccountAuditLogs")]
    [Index(nameof(AccountId), IsUnique = false)]
    [Index(nameof(CreatedDate), IsUnique = false)]
    public class AccountAuditLog
    {
        [Key]
        public long Id { get; set; }
        public long? AccountId { get; set; }
        /// <summary>
        /// Hành động: LoginSuccess, LoginFailed, Logout, ChangePassword, ResetPassword, Lockout,...
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Action { get; set; } = string.Empty;
        /// <summary>
        /// Địa chỉ IP
        /// </summary>
        [MaxLength(100)]
        public string? IpAddress { get; set; }
        /// <summary>
        /// Trình duyệt
        /// </summary>
        [MaxLength(500)]
        public string? UserAgent { get; set; }
        /// <summary>
        /// Chi tiết
        /// </summary>
        public string? Details { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
