using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlibenhvien_Offical.Function;
using Quanlibenhvien_Offical.Object;
using System.Data.SqlClient;

namespace Quanlibenhvien_Offical.Function
{
    class bhytF
    {

      
        public string IDbhyt { get; set; }
        public string IDbn { get; set; }
        Model1 md; 
        public bhytF()
        {
            md = new Model1();
        }
        public bool them(BHYT bh)
        {
            try
            {
                md.BHYTs.Add(bh);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool xoa(string id)
        {
            try
            {
                var a = md.BHYTs.Find(id);
                md.BHYTs.Remove(a);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update(BHYT bh)
        {
            try
            {
                var a = md.BHYTs.Find(bh.IDbhyt);
                a.Ngaycap = bh.Ngaycap;
                a.Ngayhethan = bh.Ngayhethan;
                a.Csbd = bh.Csbd;
              
                a.IDtuyen = bh.IDtuyen;
                a.IDdt = bh.IDdt;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
               
            }
        }
        public List<bhytF> search_bhyt(string idBHYT ,string idbn)
        {
            
            try
            {
                var a = md.Database.SqlQuery<bhytF>("search_bhyt @idBHYT,@IDbn", new SqlParameter("@idBHYT", idBHYT), new SqlParameter("@IDbn", idbn)).ToList();

                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public BHYT filter_BHYT(string idbn)
        {
            try
            {
                var a = md.BHYTs.SqlQuery("filter_BHYT @idbn", new SqlParameter("@idbn", idbn)).FirstOrDefault();
                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
