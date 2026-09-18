using Cms.Core.Domain.Content;
using Cms.Core.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cms.Data.CmsDb
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options) : base(options)
        {
        }



        #region Identity Entities
        /// <summary>
        /// Tài khoản quản trị hệ thống
        /// </summary>
        public DbSet<Account> Accounts => Set<Account>();
        /// <summary>
        /// Thông tin tài khoản quản trị hệ thống
        /// </summary>
        public DbSet<AccountProfile> AccountProfiles => Set<AccountProfile>();
        /// <summary>
        /// Vai trò quản trị hệ thống
        /// </summary>
        public DbSet<Role> Roles => Set<Role>();
        /// <summary>
        /// Vai trò của tài khoản quản trị hệ thống
        /// </summary>
        public DbSet<AccountRole> AccountRoles => Set<AccountRole>();
        /// <summary>
        /// Quyền của tài khoản quản trị hệ thống
        /// </summary>
        public DbSet<Permission> Permissions => Set<Permission>();
        /// <summary>
        /// Quyền của vai trò
        /// </summary>
        public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
        /// <summary>
        /// Token làm mới
        /// </summary>
        public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();
        /// <summary>
        /// Nhật ký hoạt động của tài khoản
        /// </summary>
        public DbSet<AccountAuditLog> AccountAuditLogs => Set<AccountAuditLog>();
        #endregion
        
        #region Content Entities
        /// <summary>
        /// Bài viết
        /// </summary>
        public DbSet<Post> Posts => Set<Post>();
        /// <summary>
        /// Danh mục bài viết
        /// </summary>
        public DbSet<PostCategory> PostCategories => Set<PostCategory>();
        /// <summary>
        /// Loạt bài viết
        /// </summary>
        public DbSet<Series> Series => Set<Series>();
        /// <summary>
        /// Thẻ
        /// </summary>
        public DbSet<Tag> Tags => Set<Tag>();
        /// <summary>
        /// Bài viết gắn thẻ
        /// </summary>
        public DbSet<PostTag> PostTags => Set<PostTag>();
        /// <summary>
        /// Bài viết trong chuỗi
        /// </summary>
        public DbSet<PostInSeries> PostInSeries => Set<PostInSeries>();
        /// <summary>
        /// Nhật ký hoạt động của bài viết
        /// </summary>
        public DbSet<PostActivityLog> PostActivityLogs => Set<PostActivityLog>();
        #endregion

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
            Builder.ApplyConfigurationsFromAssembly(typeof(CmsDbContext).Assembly);

            // Tự động cấu hình toàn bộ các bảng có Id tự tăng bắt đầu từ 1001
            Builder.UseIdentityColumns(1001, 1);
        }
        


        
    }
}
