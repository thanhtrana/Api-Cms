using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("RefreshTokens")]
    [Index(nameof(Token), IsUnique = true)]
    [Index(nameof(AccountId), IsUnique = false)]
    public class RefreshToken
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tài khoản sở hữu token
        /// </summary>
        [Required]
        public long AccountId { get; set; }
        /// <summary>
        /// Token
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string Token { get; set; } = string.Empty;
        /// <summary>
        /// Ngày tạo token
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Ngày hết hạn token
        /// </summary>
        public DateTime ExpiredDate { get; set; }
        /// <summary>
        /// Token có hoạt động không
        /// </summary>
        public bool Active { get; set; } = true;
        /// <summary>
        /// Địa chỉ IP tạo token
        /// </summary>
        [MaxLength(100)]
        public string? CreateByIp { get; set; }
        /// <summary>
        /// Ngày token bị thu hồi
        /// </summary>
        public DateTime? RevokedDate { get; set; }
        /// <summary>
        /// Địa chỉ IP thu hồi token
        /// </summary>
        [MaxLength(100)]
        public string? RevokedByIp { get; set; }
        /// <summary>
        /// Token thay thế
        /// </summary>
        [MaxLength(500)]
        public string? ReplaceByToken { get; set; }
    }
}
