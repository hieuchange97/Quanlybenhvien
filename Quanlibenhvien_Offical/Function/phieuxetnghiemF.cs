using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class phieuxetnghiemF
    {
        Model1 md;
        public phieuxetnghiemF()
        {
            md = new Model1();
        }
        public bool them(PHIEUXETNGHIEM pxn)
        {
            try
            {
                md.PHIEUXETNGHIEMs.Add(pxn);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
     
        public bool update(PHIEUXETNGHIEM pxn)
        {
            try
            {
                var a = md.PHIEUXETNGHIEMs.Find(pxn.IDpxn);
                a.gan = pxn.gan;
                a.mat = pxn.mat;
                a.tuy = pxn.tuy;
                a.lach = pxn.lach;
                a.hethongtietlieu = pxn.hethongtietlieu;
                a.tuyentienliet = pxn.tuyentienliet;
                a.mota = pxn.mota;
                a.ketluan = pxn.ketluan;
              
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
