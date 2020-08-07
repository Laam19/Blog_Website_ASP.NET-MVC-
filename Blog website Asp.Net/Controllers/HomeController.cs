﻿using Blog_website_Asp.Net.Data;
using Blog_website_Asp.Net.Data.FileManager;
using Blog_website_Asp.Net.Data.Repository;
using Blog_website_Asp.Net.Models;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
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
        private IFileManager _fileManager;

        public HomeController(
            IRepository repo,
            IFileManager fileManager
            )
        {
            _repo = repo;
            _fileManager = fileManager;
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
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mine = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(image),$"image/{mine}");
        }
       
    }
}
