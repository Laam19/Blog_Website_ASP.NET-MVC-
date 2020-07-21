using Blog_website_Asp.Net.Data;
using Blog_website_Asp.Net.Data.Repository;
using Blog_website_Asp.Net.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_website_Asp.Net.Controllers
{
    public class HomeController:Controller
    {
        private IRepository _repo;
        public HomeController(IRepository repo)
        {
            _repo = repo;
        }
        public IActionResult index()
        {
            var posts = _repo.GetAllPost();
            return View(posts);
        }

        
        public IActionResult post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }
       
    }
}
