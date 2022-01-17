using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCourseEntity.Models
{   
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navigation property Makalenin Yorumları bilgisi join için
        /// </summary>
        public List<Course> Courses { get; set; }

    }

    public class Course
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string CategoryId { get; set; } 
        public Category CourseCategory { get; set; }
    }
    public class CatologManager
    {
        public Category GetCategoryCourse()
        {


            var category = new Category
            {
                Id = "1",
                Name="Yazılım",
                Courses = new List<Course>()
            };

            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url ="/Images/java.png",
                Title="Java",
                Content="Java Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url = "/Images/Csharp.png",
                Title="C#",
                Content="C# Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url = "/Images/cplus.png",
                Title="C++",
                Content="C++ Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url = "/Images/MVC.png",
                Title="MVC",
                Content="MVC Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url = "/Images/javascript.png",
                Title="JavaScript",
                Content= "JavaScript Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                Url = "/Images/python.png",
                Title="Python",
                Content= "Python Giriş",
                Date = DateTime.Now.AddDays(-3),
                CategoryId=category.Id,
                CourseCategory=category,
            });

            return category;

        }
    }
    public class CategoryViewModel
    {
        public string CategoryId { get; set; }
        public string CategoryName{ get; set; }
        public List<CourseViewModel> CategoryCourses { get; set; }
    }
    public class CourseViewModel
    {
        public string CourseId { get; set; }
        public string CourseUrl { get; set; }
        public string CorseTitle { get; set; }
        public string CourseContent { get; set; } 
       
    }
}
