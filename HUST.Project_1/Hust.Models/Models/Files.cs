using System;

namespace Hust.Models.Models
{
    public class Files
    {
        public Guid FileId { get; set; }
        public string ReferenceType { get; set; }
        public Guid ReferenceId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string GroupKey { get; set; }
        public long Size { get; set; }
        public bool IsActive { get; set; }
        public byte[] Data { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
