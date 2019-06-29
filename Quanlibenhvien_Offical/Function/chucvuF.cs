using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Quanlibenhvien_Offical.Function
{
    class chucvuF
    {
        Model1 md;
        public chucvuF()
        {
            md = new Model1();
        }

        public bool insert_chucvu(CHUCVU cv)
        {
            try
            {
                md.CHUCVUs.Add(cv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update_chucvu(CHUCVU cv)
        {
            try
            {
                var a= md.CHUCVUs.Find(cv.IDchucvu);
                a.tenchucvu = cv.tenchucvu;


               
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool delete_chucvu(string cv)
        {
            try
            {
                var a = md.CHUCVUs.Find(cv);
                md.CHUCVUs.Remove(a);
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