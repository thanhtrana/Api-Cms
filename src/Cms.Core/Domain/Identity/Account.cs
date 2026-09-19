using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("Accounts")]
    [Index(nameof(UserName), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(NormalizedUserName), IsUnique = true)]
    [Index(nameof(NormalizedEmail), IsUnique = true)]
    public class Account
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        /// <summary>
        /// Tên đăng nhập đã chuẩn hóa
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string NormalizedUserName { get; set; } = string.Empty;
        /// <summary>
        /// Email
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Email đã chuẩn hóa
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string NormalizedEmail { get; set; } = string.Empty;
        /// <summary>
        /// Mã hash mật khẩu
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string PasswordHash { get; set; } = string.Empty;
        /// <summary>
        /// tem bảo mật thay đổi mỗi khi đổi mật khẩu hoặc bị khóa để vô hiệu hóa JWT token cũ
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// Số lần đăng nhập thất bại
        /// </summary>
        public int FailedLoginAttempts { get; set; } = 0;
        /// <summary>
        /// Số lần xác thực 2 yếu tố bị thất bại (nếu có)
        /// </summary>
        public int FailedTwoFactorAttempts { get; set; } = 0;
        /// <summary>
        /// Thời điểm khóa tài khoản
        /// </summary>
        public DateTime? LockoutEnd { get; set; }
        /// <summary>
        /// Thời điểm tạo tài khoản
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Người tạo tài khoản
        /// </summary>
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Thời điểm cập nhật tài khoản
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        /// <summary>
        /// Người cập nhật tài khoản
        /// </summary>
        public long? UpdatedBy { get; set; }
        /// <summary>
        /// Xóa mềm tài khoản
        /// </summary>
        public bool Active { get; set; }
        public bool IsActive {get; set; }



    }
}
