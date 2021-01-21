using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BLL
{
    public class QLTVbll
    {
        QLTVdal dal = new DAL.QLTVdal();

        public List<NhanVien> GetNhanViens()
        {
            return dal.GetNhanViens();
        }

        public List<Sach> GetSaches()
        {
            return dal.GetSaches();
        }

        public List<DocGia> GetDocGias()
        {
            return dal.GetDocGias();
        }

        public List<phieumuonsach> GetPhieumuonsaches()
        {
            return dal.GetPhieumuonsaches();
        }

//=======================================================================

        public DocGia CheckDocGia(DocGia d)
        {
            return dal.CheckDocGIa(d);
        }
        public void AddDocGia(DocGia d)
        {
            dal.AddDocGia(d);
            dal.Save();
        }

        public int DeleteDocGia(int d)
        {
            return dal.DeleteDocGia(d);
        }

        public void UpdateDocGia(DocGia d)
        {
            dal.UpdateDocGia(d);
        }

//=======================================================================

        public Sach CheckSach(Sach s)
        {
            return dal.CheckSach(s);
        }
        public void AddSach(Sach s)
        {
            dal.AddSach(s);
            dal.Save();
        }

        public int DeleteSach(String s)
        {
            return dal.DeleteSach(s);
        }

        public void UpdateSach(Sach s)
        {
            dal.UpdateSach(s);
        }

        //=======================================================================

        public phieumuonsach CheckPhieuMuonSach(phieumuonsach m)
        {
            return dal.CheckPhieuMuonSach(m);
        }

        public void AddPhieuMuonSach(phieumuonsach m)
        {
            dal.AddPhieuMuonSach(m);
            dal.Save();
        }

        public int DeletePhieuMuonSach(int m)
        {
            return dal.DeletePhieuMuonSach(m);
        }

        //========================================================================
        public void Save()
        {
            dal.Save();
        }
    }
}
