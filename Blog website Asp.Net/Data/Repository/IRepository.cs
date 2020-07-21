using Blog_website_Asp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_website_Asp.Net.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPost();
        void RemovePost(int id);
        void AddPost(Post post);
        void UpdatePost(Post post);

        Task<bool> SaveChangesAsync();

    }
}
