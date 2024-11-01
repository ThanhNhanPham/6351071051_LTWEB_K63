using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookstore.Models;

namespace MVCBookstore.Controllers
{
    public class BookStoreController : Controller
    {
        // GET: BookStore
        QLBansachEntities1 data = new QLBansachEntities1();

        private List<SACH> LaySachMoi(int count)
        {
            return data.SACHes.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var books = data.SACHes.ToList(); // Lấy danh sách sách từ cơ sở dữ liệu
            if (books == null || books.Count == 0)
            {
                // Xử lý nếu không có dữ liệu
                ViewBag.Message = "Không có dữ liệu sách để hiển thị.";
            }
            return View(books);
           
        }
        public ActionResult Chude()
        {
            var chude=from cd in data.CHUDEs select cd;
            return PartialView(chude);
        }
        public ActionResult Nhaxuatban()
        {
            var chude= from cd in data.NHAXUATBANs select cd;
            return PartialView(chude);
        }
        public ActionResult SPTheochude(int id) 
        {
        var sach = from s in data.SACHes where s.MaCD == id select s;
            return View(sach);
        }
        public ActionResult SPTheoNXB(int id)
        {
            var sach= from s in data.SACHes where s.MaNXB == id select s;
            return View(sach);

        }
        public ActionResult Details(int id)
        {
            var sach = from s in data.SACHes where s.Masach == id select s;
            return View(sach.Single());
        }
    }
}