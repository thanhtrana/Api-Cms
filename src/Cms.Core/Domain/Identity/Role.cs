using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Core.Domain.Identity
{
    [Table("Roles")]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(NormalizedName), IsUnique = true)]
    public class Role
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tên vai trò
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Tên vai trò đã chuẩn hóa
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string NormalizedName { get; set; } = string.Empty;
        /// <summary>
        /// Mô tả vai trò
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
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
        /// <summary>
        /// Vai trò có hoạt động không
        /// </summary>
        public bool Active { get; set; }
    }
}
