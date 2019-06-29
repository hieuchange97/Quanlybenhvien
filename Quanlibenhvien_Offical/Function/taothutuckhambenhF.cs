using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical.Function
{
    class taothutuckhambenhF
    {
        Model1 md;
        public taothutuckhambenhF()
        {
            md = new Model1();
        }

        // Tạo thủ tục trước khi làm việc 

        public bool Insert_BNLV(BENHNHANLAMVIEC bnlv)
        {
            try
            {
                md.BENHNHANLAMVIECs.Add(bnlv);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        //





        public bool insert_ba(BENHAN ba)
        {

            try
            {
                md.BENHANs.Add(ba);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool update_ba(BENHAN ba)
        {
            try
            {
                var BA = md.BENHANs.Find(ba.IDba);
                BA.Ngaybangiao = ba.Ngaybangiao;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
             
            }
        }
        public bool insert_phieukham(PHIEUKHAMBENH pk)
        {
            try
            {
                md.PHIEUKHAMBENHs.Add(pk);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
             
            }
        }
        public bool huythongtinKB(BENHAN ba , PHIEUKHAMBENH pk)
        {
           
            try
            {
                var pkb = md.PHIEUKHAMBENHs.Find(pk.IDpk);
                md.PHIEUKHAMBENHs.Remove(pkb);
                md.SaveChanges();

                var bnlv = md.BENHNHANLAMVIECs.Where(x => x.IDba == ba.IDba).ToList();
                foreach (var item in bnlv)
                {
                    item.IDba = null;
                }
                md.SaveChanges();


                var Ba = md.BENHANs.Find(ba.IDba);
                md.BENHANs.Remove(Ba);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update_phieukhambenh(PHIEUKHAMBENH pk)
          {
            try
            {
                var PK = md.PHIEUKHAMBENHs.Find(pk.IDpk);
                PK.Tieusubenh = pk.Tieusubenh;
                PK.Cacbophan = pk.Cacbophan;
                PK.Nhiptim = pk.Nhiptim;
                PK.Nhiptho = pk.Nhiptho;
                PK.Nhietdo = pk.Nhietdo;
                PK.Huyetap = pk.Huyetap;
                PK.Ketluan = pk.Ketluan;
                PK.CLS = pk.CLS;
                PK.ChuandoanCLS = pk.ChuandoanCLS;
                PK.Xuly = pk.Xuly;

                md.SaveChanges();
                return true;
        }
            catch (Exception)
            {
                return false;
                
            }
}
        public bool insert_donthuoc(DONTHUOC dt)
        {
            try
            {
                md.DONTHUOCs.Add(dt);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool insert_chitietdonthuoc(CHITIETDONTHUOC ct)
        {
            try
            {
                md.CHITIETDONTHUOCs.Add(ct);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }
        public bool delete_thuoc(string IDthuoc,string IDdonthuoc)
        {
            try
            {
               var th= md.CHITIETDONTHUOCs.Find(IDdonthuoc, IDthuoc);
                md.CHITIETDONTHUOCs.Remove(th);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool search_thuoc(CHITIETDONTHUOC ct)
        {
            try
            {
                var th = md.CHITIETDONTHUOCs.Where(x => x.IDdonthuoc == ct.IDdonthuoc && x.IDthuoc == ct.IDthuoc).First();
                if (th != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update_chitietthuoc(CHITIETDONTHUOC ct )
        {
            try
            {
                var ctt = md.CHITIETDONTHUOCs.Find(ct.IDdonthuoc, ct.IDthuoc);
                ctt.DVM = ct.DVM;
                ctt.Soluong = ct.Soluong;
                ctt.Lieudung = ct.Lieudung;
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool insert_phieutt(PHIEUTHANHTOANXNKT ptt)
        {
            try
            {
                md.PHIEUTHANHTOANXNKTs.Add(ptt);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

               
            }
        }
        public bool update_phieutt(PHIEUTHANHTOANXNKT ptt)
        {
            try
            {
                var pttxn = md.PHIEUTHANHTOANXNKTs.Find(ptt.IDpttxn);
                pttxn.IDdichvu = ptt.IDdichvu;        
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool insert_phieuhenKL(PHIEUHENKHAMLAI ph)
        {
            try
            {
                md.PHIEUHENKHAMLAIs.Add(ph);
                md.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool update_phieuhenKL(PHIEUHENKHAMLAI ph)
        {
            try
            {
              var PH = md.PHIEUHENKHAMLAIs.Find(ph.IDphieuhen);
                PH.ngayhen = ph.ngayhen;
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
