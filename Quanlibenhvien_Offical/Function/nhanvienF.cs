
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class nhanvienF
    {
        Model1 md;
        public nhanvienF()
        {
            md = new Model1();
        }
        public bool insert_nv(NHANVIEN nv)
        {
            try
            {
                md.NHANVIENs.Add(nv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool update(NHANVIEN nv, TAIKHOAN tk)
        {
            try
            {
                var NV = md.NHANVIENs.Find(nv.IDnv);
                NV.Hodem = nv.Hodem;
                NV.Ten = nv.Ten;
                NV.Sđt = nv.Sđt;
                NV.Xaphuong = nv.Xaphuong;
                NV.Quanhuyen = nv.Quanhuyen;
                NV.Tinhthanhpho = nv.Tinhthanhpho;
                NV.Gioitinh = nv.Gioitinh;
                NV.IDchucvu = nv.IDchucvu;
                NV.IDkhoa = nv.IDkhoa;
                NV.Trinhdo = nv.Trinhdo;
                if (tk != null)
                {
                    var TK = md.TAIKHOANs.Find(tk.IDtk);
                    TK.Tendn = tk.Tendn;
                    TK.Matkhau = tk.Matkhau;
                    TK.IDquyen = tk.IDquyen;
                    md.SaveChanges();
                }
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool captk(TAIKHOAN tk)
        {
            try
            {
                md.TAIKHOANs.Add(tk);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool delete_NV(string idnv)
        {
            try
            {
                var tk = md.TAIKHOANs.Where(x => x.IDnv == idnv).FirstOrDefault();
                if (tk != null)
                {
                    md.TAIKHOANs.Remove(tk);
                    md.SaveChanges();
                }
               
                var nv = md.NHANVIENs.Find(idnv);
                md.NHANVIENs.Remove(nv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}