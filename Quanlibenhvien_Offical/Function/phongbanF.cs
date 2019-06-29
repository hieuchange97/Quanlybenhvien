
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class phongbanF
    {
        Model1 md;
        public phongbanF()
        {
            md = new Model1();
        }
        public bool insert_PB(PHONGBAN pb)
        {
            try
            {
                md.PHONGBANs.Add(pb);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool update_PB(PHONGBAN pb)
        {
            try
            {
                var PB = md.PHONGBANs.Find(pb.IDpb);
                PB.Tenpb = pb.Tenpb;
                PB.Nhiemvu = pb.Nhiemvu;
               PB.Diachi= pb.Diachi;
                
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool delete_PB(string IDpb)
        {
            try
            {
                var pb = md.PHONGBANs.Find(IDpb);
                md.PHONGBANs.Remove(pb);
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