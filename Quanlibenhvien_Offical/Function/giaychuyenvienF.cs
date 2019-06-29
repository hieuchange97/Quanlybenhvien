using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
using System.Data.SqlClient;

namespace Quanlibenhvien_Offical.Function
{
    class giaychuyenvienF
    {
        public string IDgcv { get; set; }
        Model1 md;
        public giaychuyenvienF()
        {
            md = new Model1();
        }
        public bool insert_GCV(GIAYCHUYENVIEN gcv)
        {
            try
            {
                md.GIAYCHUYENVIENs.Add(gcv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool delete_GCV(string idgcv,string idbhyt)
        {
            try
            {
                var a = md.GIAYCHUYENVIENs.Find(idgcv, idbhyt);
                md.GIAYCHUYENVIENs.Remove(a);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update_GCV(GIAYCHUYENVIEN gcv)
        {
            try
            {
                var a = md.GIAYCHUYENVIENs.Find(gcv.IDgcv, gcv.IDbhyt);
                a.Ngaycap = gcv.Ngaycap;
                a.Chuandoan = gcv.Chuandoan;
                a.lydochuyen = gcv.lydochuyen;
                a.Nguoicap = gcv.Nguoicap;
                a.Noicap = gcv.Noicap;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
           
            }
        }
        public List<giaychuyenvienF> search_gcv(string txt)
        {
            try
            {
                return md.Database.SqlQuery<giaychuyenvienF>("search_GCV @txt", new SqlParameter("@txt", txt)).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public GIAYCHUYENVIEN searchGCV_idBHYT(string txt)
        {
            try
            {
                return md.GIAYCHUYENVIENs.SqlQuery("searchGCV_idBHYT @idbhyt", new SqlParameter("@idbhyt", txt)).First();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
