namespace QuanLyThuVien.DAL.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            phieumuonsaches = new HashSet<phieumuonsach>();
        }

        [Key]
        [StringLength(10)]
        public string masach { get; set; }

        [StringLength(200)]
        public string tensach { get; set; }

        [StringLength(4)]
        public string namxuatban { get; set; }

        [StringLength(100)]
        public string theloai { get; set; }

        [StringLength(100)]
        public string tacgia { get; set; }

        [StringLength(100)]
        public string nxb { get; set; }

        public int? soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieumuonsach> phieumuonsaches { get; set; }
    }
}
