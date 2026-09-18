using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("Permissions")]
    [Index(nameof(Code), IsUnique = true)]
    public class Permission
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Mã định danh quyền
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Code { get; set; } = string.Empty;
        /// <summary>
        /// Tên quyền
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Nhóm quyền
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string GroupName { get; set; } = string.Empty;
        /// <summary>
        /// Mô tả quyền
        /// </summary>
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
