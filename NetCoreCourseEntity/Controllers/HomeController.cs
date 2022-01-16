using Microsoft.AspNetCore.Mvc;
using NetCoreCourseEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCourseEntity.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet("catolog-detail/{categoryId}")]
        public IActionResult Index(string categoryId)
        {
            // db nesnesi
            var category = new CatologManager().GetCategoryCourse();

            //if (category.Id != categoryId)
            //{
            //    // kayıt yok sayfası döndürsün.
            //    return NotFound();
            //}

            // post datasını alıp view modelle mappledik. yani post entity bilgisi ile view'e gönderilecek olan modeli doldurduk.

            var model = new CategoryViewModel
            {
                CategoryId = category.Id,
                CategoryName = category.Name,
                CategoryCourses = category.Courses.Select(a => new CourseViewModel
                {
                    CorseTitle = a.Title,
                    CourseContent = a.Content,
                    CourseUrl = a.Url
                }).ToList()
            };


            return View(model);
        }
        [HttpPost("send-course")] // Json olarak veri gönderdiğimizde post bodyden veriyi yakalamamızı sağlar. sadece application/json tipinde veri gönderebiliriz. [FromForm] ise dün postman üzerinden x-www-urlencoded olarak veri gönderdiğimiz yöntem.
        public JsonResult SendCourse([FromBody] CategoryInputModel model)
        {
            // database kayıt.
            return Json(new { message = "Kayıt başarılı" });
        }
    }

}
