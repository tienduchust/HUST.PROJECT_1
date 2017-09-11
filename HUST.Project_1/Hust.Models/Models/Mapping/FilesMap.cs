using System.Data.Entity.ModelConfiguration;

namespace Hust.Models.Mapping
{
    public class FilesMap : EntityTypeConfiguration<Files>
    {
        public FilesMap()
        {
            // Primary Key
            this.HasKey(t => t.FileId);

            // Property
            this.Property(t => t.FileId).HasColumnName("File_ID");
            this.Property(t => t.ReferenceId).HasColumnName("Reference_ID");

            // Table & Column Mappings
            this.ToTable("Files");
        }
    }
}