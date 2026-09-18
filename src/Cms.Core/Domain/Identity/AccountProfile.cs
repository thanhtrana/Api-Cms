using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("AccountProfiles")]
    [Index(nameof(AccountId), IsUnique = true)]
    public class AccountProfile
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tài khoản sở hữu profile
        /// </summary>
        [Required]
        public long AccountId { get; set; }
        /// <summary>
        /// Họ tên
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;
        /// <summary>
        /// Số điện thoại
        /// </summary>
        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; } = string.Empty;
        /// <summary>
        /// Avatar
        /// </summary>
        [MaxLength(500)]
        public string Avatar { get; set; } = string.Empty;
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        [MaxLength(500)]
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Thành phố
        /// </summary>
        [MaxLength(100)]
        public string City { get; set; } = string.Empty;
        /// <summary>
        /// Quốc gia
        /// </summary>
        public string Country { get; set; } = string.Empty;
        /// <summary>
        /// Ngày tạo profile
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Người tạo profile
        /// </summary>
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Ngày cập nhật profile
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        /// <summary>
        /// Người cập nhật profile
        /// </summary>
        public long? UpdatedBy { get; set; }
        /// <summary>
        /// Profile có hoạt động không
        /// </summary>
        public bool Active { get; set; }
    }
}
