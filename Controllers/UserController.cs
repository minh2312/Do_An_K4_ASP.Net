using DoAN_k4.Data;
using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DoAN_k4.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public UserController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

/*        public async Task<IActionResult> Index()
        {
            int limit = 5;
            List<User> userList = await _dbContext.users.Find(_ => true).ToListAsync();
            return View(userList);
        }*/


        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 5; 

            List<User> userList = await _dbContext.users.Find(_ => true).ToListAsync();

            IPagedList<User> pagedListUsers = userList.ToPagedList(page ?? 1, pageSize);

            return View(pagedListUsers);
        }



        public async Task<IActionResult> Detail(string idUser)
        {
            var user = await _dbContext.users.Find(u => u.Id == idUser ).FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound();
            }

            var userPosts = await _dbContext.posts
                .Find(p => p.UserId == idUser && p.Status == true)
                .SortByDescending(p => p.CreatedAt)
                .ToListAsync();

            ViewBag.User = user;
            return View(userPosts);
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
        public async Task<IActionResult> BanUser(string idUser)
        {
            if (!ObjectId.TryParse(idUser, out ObjectId objectId))
            {
                return BadRequest("Invalid post ID format.");
            }

            var update = Builders<User>.Update.Set(u => u.Status, false);
            var updateResult = await _dbContext.users.UpdateOneAsync(u => u.Id == idUser, update);

            if (updateResult.ModifiedCount == 0)
            {
                return NotFound("Post not found.");
            }

            return Ok("Post status updated to 0.");
        }

        [HttpPost]
        public async Task<IActionResult> UnlockAccount(string idUser)
        {
            if (!ObjectId.TryParse(idUser, out ObjectId objectId))
            {
                return BadRequest("Invalid post ID format.");
            }

            var update = Builders<User>.Update.Set(u => u.Status, true);
            var updateResult = await _dbContext.users.UpdateOneAsync(u => u.Id == idUser, update);

            if (updateResult.ModifiedCount == 0)
            {
                return NotFound("Post not found.");
            }

            return Ok("Post status updated to 0.");
        }
    }
}
