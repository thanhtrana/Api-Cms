using Cms.Core.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Data.Configurations.Identity
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> entity)
        {
            // Cấu hình tên bảng trong Database
            entity.ToTable("Accounts");

            // Cấu hình khóa chính
            entity.HasKey(x => x.Id);

            // Cấu hình các thuộc tính
            entity.Property(x => x.UserName) // Tên đăng nhập
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(100) // Tối đa 100 ký tự
                .IsUnicode(false); // Lưu dạng VARCHAR không dấu (tối ưu lưu trữ và tìm kiếm)

            entity.Property(x => x.NormalizedUserName) // Tên đăng nhập chuẩn hóa (viết hoa)
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(100) // Tối đa 100 ký tự
                .IsUnicode(false); // Lưu dạng VARCHAR không dấu

            entity.Property(x => x.Email) // Email tài khoản
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(100) // Tối đa 100 ký tự
                .IsUnicode(false); // Lưu dạng VARCHAR không dấu

            entity.Property(x => x.NormalizedEmail) // Email chuẩn hóa (viết hoa)
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(100) // Tối đa 100 ký tự
                .IsUnicode(false); // Lưu dạng VARCHAR không dấu

            entity.Property(x => x.PasswordHash) // Mật khẩu đã được mã hóa (Hash)
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(256); // Tối đa 256 ký tự

            entity.Property(x => x.SecurityStamp) // Tem bảo mật (dùng vô hiệu hóa Token cũ khi đổi mật khẩu)
                .IsRequired() // Bắt buộc phải có
                .HasMaxLength(256); // Tối đa 256 ký tự

            entity.Property(x => x.FailedLoginAttempts) // Số lần đăng nhập sai
                .HasDefaultValue(0); // Giá trị mặc định là 0

            entity.Property(x => x.FailedTwoFactorAttempts) // Số lần xác thực 2 bước thất bại
                .HasDefaultValue(0); // Giá trị mặc định là 0

            entity.Property(x => x.LockoutEnd) // Thời điểm hết hạn khóa tài khoản
                .IsRequired(false); // Cho phép giá trị NULL (khi tài khoản không bị khóa)

            entity.Property(x => x.CreatedDate) // Thời gian tạo tài khoản
                .HasDefaultValueSql("GETUTCDATE()"); // Tự động gán thời gian UTC hiện tại trong SQL

            entity.Property(x => x.CreatedBy) // Người tạo tài khoản
                .IsRequired(false); // Cho phép NULL

            entity.Property(x => x.UpdatedDate) // Thời gian cập nhật tài khoản lần cuối
                .IsRequired(false); // Cho phép NULL

            entity.Property(x => x.UpdatedBy) // Người cập nhật tài khoản lần cuối
                .IsRequired(false); // Cho phép NULL

            entity.Property(x => x.Active) // Trạng thái hoạt động
                .HasDefaultValue(true); // Mặc định là kích hoạt (true)

            entity.Property(x => x.IsActive) // Trạng thái kích hoạt
                .HasDefaultValue(true); // Mặc định là kích hoạt (true)

            // Cấu hình các chỉ mục duy nhất (Unique Index) để chống trùng lặp và tăng tốc truy vấn
            entity.HasIndex(x => x.UserName) // Index cho tên đăng nhập
                .IsUnique(); // Không được trùng lặp

            entity.HasIndex(x => x.NormalizedUserName) // Index cho tên đăng nhập chuẩn hóa
                .IsUnique(); // Không được trùng lặp

            entity.HasIndex(x => x.Email) // Index cho Email
                .IsUnique(); // Không được trùng lặp

            entity.HasIndex(x => x.NormalizedEmail) // Index cho Email chuẩn hóa
                .IsUnique(); // Không được trùng lặp
        }
    }
}
