namespace QuanLyThuVien.DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phieumuonsach")]
    public partial class phieumuonsach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maphieumuon { get; set; }

        [Required]
        [StringLength(10)]
        public string masach { get; set; }

        public int madocgia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaymuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytra { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
