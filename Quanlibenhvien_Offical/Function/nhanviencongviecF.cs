
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Function;
using Quanlibenhvien_Offical.Object;
namespace Quanlibenhvien_Offical.Function
{
    class nhanviencongviecF
    {

        public string IDnv { get; set; }
        public string hodem { get; set; }

        public string Ten { get; set; }
        public string Tenbophan { get; set; }
        public string Tenpb { get; set; }
        public string tendiadiem { get; set; }
        public DateTime thoigianbatdau { get; set; }
        public DateTime thoigianketthuc { get; set; }




        Model1 md;
        public nhanviencongviecF()
        {
            md = new Model1();
        }
        public bool insert_nvlv(NHANVIENLAMVIEC nvlv)
        {
            try
            {
                md.NHANVIENLAMVIECs.Add(nvlv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
 
            }
        }
        public bool update_nvlv(NHANVIENLAMVIEC nvlv)
        {
            try
            {
            //    var Nvlv = md.NHANVIENLAMVIECs.Find(nvlv.IDnv, nvlv.IDpb, nvlv.IDdiadiem);
            //    Nvlv.Thoigianbatdau = nvlv.Thoigianbatdau;
            //    Nvlv.Thoigianketthuc = nvlv.Thoigianketthuc;
            //    md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool delete_nvlv(NHANVIENLAMVIEC nvlv)
        {
            try
            {
                //var Nvlv = md.NHANVIENLAMVIECs.Find(nvlv.IDnv, nvlv.IDpb, nvlv.IDdiadiem);
                //md.NHANVIENLAMVIECs.Remove(Nvlv);
                //md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}