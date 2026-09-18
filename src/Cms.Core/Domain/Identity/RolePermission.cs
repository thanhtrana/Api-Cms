using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("RolePermissions")]
    [Index(nameof(RoleId), IsUnique = false)]
    [Index(nameof(PermissionId), IsUnique = false)]
    [Index(nameof(RoleId), nameof(PermissionId), IsUnique = true)]
    public class RolePermission
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Vai trò sở hữu quyền
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// Quyền sở hữu vai trò
        /// </summary>
        public long PermissionId { get; set; }
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
