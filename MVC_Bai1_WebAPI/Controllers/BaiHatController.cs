using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Bai1_WebAPI.Controllers
{
    public class BaiHatController : ApiController
    {
        [HttpGet]
       public List<tbl_BaiHat> GetBaiHatLists()
        {
            DBBaiHatDataContext db = new DBBaiHatDataContext();
            return db.tbl_BaiHats.ToList();
        }
        [HttpGet]
        public tbl_BaiHat GetBaiHat(int id)
        {
            DBBaiHatDataContext db = new DBBaiHatDataContext();
            return db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == id);
        }
        [HttpPost]
        public int InsertNewBaiHat(string TenBH, int MaTL, int MaNs)
        {
            try
            {
                DBBaiHatDataContext db = new DBBaiHatDataContext();
                tbl_BaiHat s = new tbl_BaiHat();
                s.TenBH = TenBH;
                s.MaTL = MaTL;
                s.MaNS = MaNs;
               // db.tb1_BaiHats.InsertOnSubmit(s);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        [HttpPut]
        public bool UpdateBaiHat(int MaBH, String TenBH, int MaTL, int MaNS)
        {
            try
            {
                DBBaiHatDataContext db = new DBBaiHatDataContext();
                tbl_BaiHat song = db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == MaBH);
                if (song == null) return false;
                song.TenBH = TenBH;
                song.MaTL = MaTL;
                song.MaNS = MaNS;
                db.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }
        [HttpDelete]
        public bool DeleteBaiHat(int Ma)
        {
            DBBaiHatDataContext db = new DBBaiHatDataContext();
            tbl_BaiHat song = db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == Ma);
            if (song == null) return false;
            db.tbl_BaiHats.DeleteOnSubmit(song);
            db.SubmitChanges();
            return true;
        }
    }
}
