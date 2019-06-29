
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class quyentruycapF
    {
        Model1 md; 
        public quyentruycapF()
        {
            md = new Model1();
        }
        public bool insert_quyen(PHANQUYEN q)
        {
            try
            {
                md.PHANQUYENs.Add(q);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
            public bool update_quyen(PHANQUYEN q)
            {
                try
                {
                    var Q = md.PHANQUYENs.Find(q.IDquyen);
                    Q.Tenquyen = q.Tenquyen;                
                    md.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool delete_quyen(string idq)
            {
                try
                {
                     var q = md.PHANQUYENs.Find(idq);
                    md.PHANQUYENs.Remove(q);
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