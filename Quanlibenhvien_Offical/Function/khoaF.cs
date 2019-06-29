using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class khoaF
    {
        Model1 md;
        public khoaF()
        {
            md = new Model1();
        }
        public bool insert_kh(KHOA kh)
        {
            try
            {
                md.KHOAs.Add(kh);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
        }
        public bool update_kh(KHOA kh)
        {
            try
            {
                var KH = md.KHOAs.Find(kh.IDkhoa);
                KH.Tenkhoa = kh.Tenkhoa;
                KH.IDtruongkhoa = kh.IDtruongkhoa;
                KH.Ngaythanhlap = kh.Ngaythanhlap;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool delete_kh(string idkh)
        {
            try
            {
                var a = md.KHOAs.Find(idkh);
                md.KHOAs.Remove(a);
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