using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlibenhvien_Offical.Object;
using System.Data.SqlClient;
namespace Quanlibenhvien_Offical.Function
{
    class benhnhanF
    {
        public Int64 STT { get; set; }
        public string IDbn { get; set; }
        public string hodem { get; set; }
        public string Ten { get; set; }
       public string gioitinh { get; set; }
        public DateTime? ngaysinh { get; set; }
        public string Sdt { get; set; }
        public string Xaphuong { get; set; }
        public string Quanhuyen { get; set; }
        public string Tinhthanhpho { get; set; }
        public string Nghenghiep { get; set; }
        public string CMTND { get; set; }
        public string Giaykhaisinh { get; set; }
        Model1 md;
        public benhnhanF()
        {
            md = new Model1();
        }
     
        public List<benhnhanF> show_bn()
        {
            return new Model1().Database.SqlQuery<benhnhanF>("show_bn").ToList();
        }
        public bool insert_bn(BENHNHAN bn)
        {
            try
            {
                md.BENHNHANs.Add(bn);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
        }
        public bool update_bn(BENHNHAN bnn)
        {


            var bn = md.BENHNHANs.Where(x => x.IDbn == bnn.IDbn).First();
            bn.hodem = bnn.hodem;
            bn.Ten = bnn.Ten;
            bn.gioitinh = bnn.gioitinh;
            bn.ngaysinh = bnn.ngaysinh;
            bn.Xaphuong = bnn.Xaphuong;
            bn.Quanhuyen = bnn.Quanhuyen;
            bn.Tinhthanhpho = bnn.Tinhthanhpho;
            bn.Nghenghiep = bnn.Nghenghiep;
            bn.CMTND = bnn.CMTND;
            bn.Giaykhaisinh = bnn.Giaykhaisinh;
            bn.Sdt = bnn.Sdt;
            md.SaveChanges();
            return true;

        } 
        public bool delete_bn(string bn )
        {
            try
            {
                var a = md.BENHNHANs.Find(bn);
                md.BENHNHANs.Remove(a);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<benhnhanF> search_hotenBN(string ten)
        {



            try
            {
                var a = md.Database.SqlQuery<benhnhanF>("ttsearch_hotenBN @ten", new SqlParameter("@ten", ten)).ToList();
                return a;
            }
            catch (Exception)
            {
                return null;

            }
        }
        public List<benhnhanF> search_cmndBN(string txt)
        {
            try
            {
                var a = md.Database.SqlQuery<benhnhanF>("search_cmndBN @cmnd", new SqlParameter("@cmnd", txt)).ToList();
                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<benhnhanF> search_idBN(string txt)
        {
            try
            {
                var a = md.Database.SqlQuery<benhnhanF>("searchBN_IDbn @idbn", new SqlParameter("@idbn", txt)).ToList();
                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<benhnhanF> search_gksBN(string txt)
        {
            try
            {
                var a = md.Database.SqlQuery<benhnhanF>("search_gksBN @gks", new SqlParameter("@gks", txt)).ToList();
                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<benhnhanF> search_bhytBN(string txt)
        {
            try
            {
                var a = md.Database.SqlQuery<benhnhanF>("search_bhytBN @bhyt", new SqlParameter("@bhyt", txt)).ToList();
                return a;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
