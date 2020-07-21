﻿using Blog_website_Asp.Net.Data.Repository;
using Blog_website_Asp.Net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_website_Asp.Net.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PanelController:Controller
    {
        private IRepository _repo;
        public PanelController(IRepository repo)
        {
            _repo = repo;
        }
        public IActionResult index()
        {
            var posts = _repo.GetAllPost();
            return View(posts);
        }


        
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View(new Post());
            else
            {
                var post = _repo.GetPost((int)id);
                return View(post);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            if (post.Id > 0)
                _repo.UpdatePost(post);
            else
                _repo.AddPost(post);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("index");
            else
                return View(post);
        }
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("index");

        }
    }
}
