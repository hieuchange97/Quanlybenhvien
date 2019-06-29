
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class dichvuF
    {

        Model1 md;
        public dichvuF()
        {
            md = new Model1();
        }
        public bool insert_DV(DICHVU dv)
        {
            try
            {
                md.DICHVUs.Add(dv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool uodate_DV(DICHVU dv)
        {
            try
            {
                var a = md.DICHVUs.Find(dv.IDdichvu);
                a.TenDV = dv.TenDV;
                a.Giatien = dv.Giatien;
                a.Maymoc = dv.Maymoc;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool delete_dv(string id)
        {
            try
            {
                var dv = md.DICHVUs.Find(id);
                md.DICHVUs.Remove(dv);
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