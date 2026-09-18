using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("AccountRoles")]
    [Index(nameof(AccountId), nameof(RoleId), IsUnique = true)] // Kiểm tra trùng lặp
    [Index(nameof(AccountId), IsUnique = false)]
    [Index(nameof(RoleId), IsUnique = false)]
    public class AccountRole
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tài khoản sở hữu vai trò
        /// </summary>
        public long AccountId { get; set; }
        /// <summary>
        /// Vai trò
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// Ngày tạo vai trò
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// Người tạo vai trò
        /// </summary>
        public long? CreatedBy { get; set; }
        /// <summary>
        /// Ngày cập nhật vai trò
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        /// <summary>
        /// Người cập nhật vai trò
        /// </summary>
        public long? UpdatedBy { get; set; }
    }
}
