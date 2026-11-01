using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduManager.Models
{
    [Table("MONHOC")]
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string MaMonHoc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMonHoc { get; set; }

        public int SoTinChi { get; set; }

        public bool TrangThai { get; set; }
    }
}
