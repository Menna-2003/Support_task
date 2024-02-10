using Microsoft.AspNetCore.Mvc;
using task.Models;

namespace task.Controllers {
    public class BlogController : Controller {
        private static List<Blog> _blogs = new List<Blog>();

        public IActionResult Index () {
            return View();
        }
        public IActionResult AddBlog() {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog (Blog blog) {
            int id = 0;
            if ( _blogs.Count == 0 ) {
                id = 1;
            } else {
                id = _blogs.Max( x => x.Id+1 );
            }
            blog.Id = id++;
            _blogs.Add(blog);
            return RedirectToAction( "index" );
        }
        #region GetAll
        public IActionResult GetAllData() {
            return View( _blogs );
        }
        #endregion

        #region DeleteProduct
        public IActionResult Delete ( int id ) {
            Blog blog = _blogs.FirstOrDefault(x => x.Id == id);
            _blogs.Remove(blog);

            return RedirectToAction("GetAllData");
        }
        #endregion


    }
}
