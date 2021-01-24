using QuanLyThuVien.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    public class QLTVdal
    {
        QuanLyThuVienbd db = new QuanLyThuVienbd();
        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }
        public List<Sach> GetSaches()
        {
            return db.Saches.ToList();
        }
        
        public List<DocGia> GetDocGias()
        {
            return db.DocGias.ToList();
        }
        
        public List<phieumuonsach> GetPhieumuonsaches()
        {
            return db.phieumuonsaches.ToList();
        }

        //================================================================================

        public NhanVien CheckNhanVien(NhanVien d)
        {
            return db.NhanViens.FirstOrDefault(p => p.manhanvien == d.manhanvien);
        }

        public void AddNhanVien(NhanVien d)
        {
                db.NhanViens.Add(d);
        }

        public int DeleteNhanVien(int d)
        {
            NhanVien delete = db.NhanViens.FirstOrDefault(p => p.manhanvien == d.ToString());
            if (delete != null)
            {
                db.NhanViens.Remove(delete);
                Save();
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public void UpdateNhanVien(NhanVien d)
        {
            NhanVien update = CheckNhanVien(d);
            if (update != null)
            {
                update.manhanvien = d.manhanvien;
                update.tennhanvien = d.tennhanvien;
                update.ngaysinh = d.ngaysinh;
                update.diachi = d.diachi;
                update.sdt = d.sdt;
                update.cmnd = d.cmnd;
            }
            Save();
        }

       
        

        

        //================================================================================


        public DocGia CheckDocGIa(DocGia d)
        {
            return db.DocGias.FirstOrDefault(p => p.madocgia == d.madocgia);
        }

        public void AddDocGia(DocGia d)
        {
            db.DocGias.Add(d);
        }

        public int DeleteDocGia(int d)
        {
            DocGia delete = db.DocGias.FirstOrDefault(p => p.madocgia == d);
            if(delete != null)
            {
                db.DocGias.Remove(delete);
                Save();
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public void UpdateDocGia(DocGia d)
        {
            DocGia update = CheckDocGIa(d);
            if(update != null)
            {
                update.madocgia = d.madocgia;
                update.tendocgia = d.tendocgia;
                update.ngaysinh = d.ngaysinh;
                update.diachi = d.diachi;
                update.sdt = d.sdt;
                update.cmnd = d.cmnd;
            }
            Save();
        }

        //================================================================================

        public Sach CheckSach(Sach s)
        {
            return db.Saches.FirstOrDefault(p => p.masach == s.masach);
        }

        public Sach AddSach(Sach s)
        {
            return db.Saches.Add(s);
        }

        public int DeleteSach(String d)
        {
            Sach delete = db.Saches.FirstOrDefault(p => p.masach == d);
            if (delete != null)
            {
                db.Saches.Remove(delete);
                Save();
                return 1;
            }
            else
                return -1;
        }

        public void UpdateSach(Sach s)
        {
            Sach update = CheckSach(s);
            if(update != null)
            {
                update.masach = s.masach;
                update.tensach = s.tensach;
                update.namxuatban = s.namxuatban;
                update.theloai = s.theloai;
                update.tacgia = s.tacgia;
                update.nxb = s.nxb;
                update.soluong = Convert.ToInt32(s.soluong);
            }
            Save();
        }
        //================================================================================

        public phieumuonsach CheckPhieuMuonSach(phieumuonsach m)
        {
            return db.phieumuonsaches.FirstOrDefault(p => p.maphieumuon == m.maphieumuon);
        }

        public phieumuonsach AddPhieuMuonSach(phieumuonsach m)
        {
            return db.phieumuonsaches.Add(m);
        }

        public int DeletePhieuMuonSach(int m)
        {
            phieumuonsach delete = db.phieumuonsaches.FirstOrDefault(p => p.maphieumuon == m);
            if (delete != null)
            {
                db.phieumuonsaches.Remove(delete);
                Save();
                return 1;
            }
            else
                return -1;
        }
//=================================================================================


        public void Save()
        {
            db.SaveChanges();
        }
    }
}
