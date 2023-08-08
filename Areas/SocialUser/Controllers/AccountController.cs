using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_k4.Areas.SocialUser.Controllers
{
    public class AccountController : BaseController
    {
        public string urlConnectApi = "http://localhost:3000/";
        public async Task<IActionResult> Index(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                // loginUser
                userId = "64bb92776f471d50889347df";
            }
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // id của user đang log in 
                    var loggedInUserId = "64bb92776f471d50889347df";
                    var dataPost = new { userId, loggedInUserId };
                    var jsonPost = JsonConvert.SerializeObject(dataPost);
                    var contentPost = new StringContent(jsonPost, Encoding.UTF8, "application/json");
                    var postResponse = await httpClient.PostAsync(urlConnectApi + "userPosts", contentPost);

                    List<Posts> listPost = new List<Posts>();
                    if (postResponse.IsSuccessStatusCode)
                    {
                        string postJsonResult = await postResponse.Content.ReadAsStringAsync();
                        listPost = JsonConvert.DeserializeObject<List<Posts>>(postJsonResult);
                    }
                    ViewBag.ListPost = listPost;


                    var response = await httpClient.GetAsync(urlConnectApi + "users/" + userId + "?loggedInUserId=" + loggedInUserId);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseJsonResult = await response.Content.ReadAsStringAsync();
                        User user = JsonConvert.DeserializeObject<User>(responseJsonResult);
                        return View(user);
                    }
                    else
                    {
                        return View("Error");
                    }
                }
                catch (Exception ex)
                {
                    return View("Error : " + ex.Message);
                }
            }
        }
        [HttpPost]
        public async Task<IActionResult> FollowUser(string id)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var loggedInUserId = "64bb92776f471d50889347df"; // loginUser Id
                    var response = await httpClient.PostAsync(urlConnectApi + "users/" + id + "/follow?loggedInUserId=" + loggedInUserId, null);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                        bool followed = result.followed;
                        return Json(new { followed });
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Failed to follow/unfollow user: " + ex.Message });
            }
        }

    }
}
