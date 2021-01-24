namespace QuanLyThuVien.DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(10)]
        public string manhanvien { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }

        [StringLength(200)]
        public string tennhanvien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public string diachi { get; set; }

        [Required]
        [StringLength(10)]
        public string sdt { get; set; }

        [Required]
        [StringLength(9)]
        public string cmnd { get; set; }

        public int phanquyenne { get; set; }
    }
}
