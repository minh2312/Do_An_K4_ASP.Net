using DoAN_k4.Data;
using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace DoAN_k4.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public PostController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        /*public async Task<IActionResult> Index(int? page, string searchString)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;

            List<Posts> posts = await _dbContext.posts.Find(_ => true).ToListAsync();
            IPagedList<Posts> pagedPosts = posts.ToPagedList(pageNumber, pageSize);

            return View(pagedPosts);
        }*/

        public async Task<IActionResult> Index(int? page, string searchString)
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;

            var filterBuilder = Builders<Posts>.Filter;
            var filter = filterBuilder.Empty; // Start with an empty filter

            if (!string.IsNullOrEmpty(searchString))
            {
                // Add search condition based on title or content
                filter = filter & (filterBuilder.Regex("Post", new BsonRegularExpression(searchString, "i")) );
            }

            List<Posts> posts = await _dbContext.posts.Find(filter).ToListAsync();
            IPagedList<Posts> pagedPosts = posts.ToPagedList(pageNumber, pageSize);

            return View(pagedPosts);
        }

        public async Task<IActionResult> Detail(string idPost)
        {
            if (string.IsNullOrEmpty(idPost))
            {
                return NotFound();
            }

            var post = await _dbContext.posts.Find(p => p.Id == idPost).FirstOrDefaultAsync();

            if (post == null)
            {
                return NotFound();
            }

            var user = await _dbContext.users.Find(u => u.Id == post.UserId).FirstOrDefaultAsync();

            ViewBag.User = user;


            return View(post);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePost(string postId)
        {
            if (!ObjectId.TryParse(postId, out ObjectId objectId))
            {
                return BadRequest("Invalid post ID format.");
            }

            var update = Builders<Posts>.Update.Set(p => p.Status, false);
            var updateResult = await _dbContext.posts.UpdateOneAsync(p => p.Id == postId, update);

            if (updateResult.ModifiedCount == 0)
            {
                return NotFound("Post not found.");
            }

            return Ok("Post status updated to 0.");
        }


        [HttpPost]
        public async Task<IActionResult> UnlockPost(string idPost)
        {
            if (!ObjectId.TryParse(idPost, out ObjectId objectId))
            {
                return BadRequest("Invalid post ID format.");
            }

            var update = Builders<Posts>.Update.Set(p => p.Status, true);
            var updateResult = await _dbContext.posts.UpdateOneAsync(p => p.Id == idPost, update);

            if (updateResult.ModifiedCount == 0)
            {
                return NotFound("Post not found.");
            }

            return Ok("Post status updated to 0.");
        }
    }
}
