using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mybasics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
                   new Course(){
                Id=1,
                Title="asp kursu",
                Description="harika bir kurs",
                Image="1.jpg",
                Tags= new string[]{"asp", "kurs"},
                isActive=true,
                isHome=true,
            },
            new Course(){
                Id=2,
                Title="php kursu",
                Description="güzel bir kurs",
                Image="2.jpg",
                isActive=true,
                isHome=true,
            },
            new Course(){
                Id=3,
                Title="django kursu",
                Description="mükemmel bir kurs",
                Image="3.jpg",
                Tags= new string[]{"django", "python","kurs"},
                isActive=true,
                isHome=false,
            },
             new Course(){
                Id=4,
                Title="javascript kursu",
                Description="mükemmel bir kurs",
                Image="1.jpg",
                Tags= new string[]{"javascript", "kurs","html","css","bootstrap"},
                isActive=true,
                isHome=true,
            },
            };
        }

        public static List<Course> Courses
        {
            get { return _courses; }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}