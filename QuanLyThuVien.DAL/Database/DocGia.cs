namespace QuanLyThuVien.DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            phieumuonsaches = new HashSet<phieumuonsach>();
        }

        [Key]
        public int madocgia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(11)]
        public string UserID { get; set; }

        [StringLength(200)]
        public string tendocgia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public string diachi { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(9)]
        public string cmnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieumuonsach> phieumuonsaches { get; set; }
    }
}
