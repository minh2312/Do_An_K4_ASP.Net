using DoAN_k4.Data;
using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DoAN_k4.Areas.SocialUser.Controllers
{
    [Area("SocialUser")]
    public class HomeController : BaseController
    {
        private readonly ApplicationDBContext _dbContext;
        public string urlConnectApi = "http://localhost:3000/";
        public HomeController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var userId = HttpContext.Session.GetString("UserLogin"); // loginUser Id
                    var data = new { userId };
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");


                    // Get list of followers
                    var followerResponse = await httpClient.GetAsync(urlConnectApi + "users/followers/" + userId);

                    List<Follower> followers = new List<Follower>();
                    if (followerResponse.IsSuccessStatusCode)
                    {
                        string followerJsonResult = await followerResponse.Content.ReadAsStringAsync();
                        followers = JsonConvert.DeserializeObject<List<Follower>>(followerJsonResult);
                    }
                    ViewBag.Follower = followers;
                    // Get list of followerings
                    var followingsResponse = await httpClient.GetAsync(urlConnectApi + "users/followerings/" + userId);

                    List<Follower> followering = new List<Follower>();
                    if (followingsResponse.IsSuccessStatusCode)
                    {
                        string followeringJsonResult = await followingsResponse.Content.ReadAsStringAsync();
                        followering = JsonConvert.DeserializeObject<List<Follower>>(followeringJsonResult);
                    }
                    ViewBag.Following = followering;


                    var response = await httpClient.PostAsync(urlConnectApi + "listPost", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        List<Posts> items = JsonConvert.DeserializeObject<List<Posts>>(jsonResult);

                        // Pass the items to the view
                        return View(items);
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
        public async Task<IActionResult> UpdatePostLikes(string postId)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // loginUser Id
                    var userId = HttpContext.Session.GetString("UserLogin");
                    var data = new { userId };
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await httpClient.PutAsync(urlConnectApi + "posts/" + postId + "/like", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var apiResponse = await response.Content.ReadAsStringAsync();

                        var jObject = JObject.Parse(apiResponse);
                        var liked = jObject.Value<bool>("liked");
                        return Json(new { liked = liked });
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "An error occurred: " + ex.Message);
                }
            }
        }

        public async Task<IActionResult> GetPostDetail(string postId)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    //loginUser Id
                    var userId = HttpContext.Session.GetString("UserLogin");
                    var data = new { userId };
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync(urlConnectApi + "postDetail/" + postId, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        Posts items = JsonConvert.DeserializeObject<Posts>(jsonResult);

                        return View(items);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "An error occurred: " + ex.Message);
                }
            }
        }
        [HttpPost]
        public async Task<IActionResult> PostComment(string postId, string content)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //  loginUser Id
                    var userId = HttpContext.Session.GetString("UserLogin");

                    var data = new { userId, content };
                    var json = JsonConvert.SerializeObject(data);
                    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync(urlConnectApi + "posts/cmt/" + postId, httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        return Json(jsonResponse);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred: " + ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(string post, IFormFile media)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //  loginUser Id
                    var userId = HttpContext.Session.GetString("UserLogin");
                    // Kiểm tra xem có ảnh được upload hay không
                    string imageUrl = "";
                    if (media != null)
                    {
                        bool isImage = media.ContentType.StartsWith("image/");
                        bool isVideo = media.ContentType.StartsWith("video/");

                        if (!isImage && !isVideo)
                        {
                            return BadRequest("Invalid file type. Only image and video files are allowed.");
                        }

                        // Gửi ảnh/lưu trữ video lên API/Server để upload
                        var formData = new MultipartFormDataContent();
                        var streamContent = new StreamContent(media.OpenReadStream());
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue(media.ContentType);
                        formData.Add(streamContent, "media", media.FileName);

                        var uploadResponse = await httpClient.PostAsync("http://localhost:3000/upload", formData);

                        if (!uploadResponse.IsSuccessStatusCode)
                        {
                            return BadRequest("Failed to upload media.");
                        }

                        var uploadResult = await uploadResponse.Content.ReadAsStringAsync();
                        var filename = JsonConvert.DeserializeObject<dynamic>(uploadResult).filename;

                         imageUrl = $"http://10.0.2.2:3000/public/uploads/{filename}";
                    }

                    // Gửi thông tin bài viết lên API để tạo bài viết
                    var postData = new
                    {
                        userId,
                        post,
                        postImg = imageUrl
                    };

                    var json = JsonConvert.SerializeObject(postData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var postResponse = await httpClient.PostAsync(urlConnectApi + "posts", content);
                    if (!postResponse.IsSuccessStatusCode)
                    {
                        return BadRequest("Failed to create post.");
                    }

                    var postResult = await postResponse.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<dynamic>(postResult);

                    return Json(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Failed to create post: " + ex.Message });
            }
        }
        [HttpPost]
        public async Task<bool> DeletePost(string postId)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.DeleteAsync(urlConnectApi + "posts/"+postId);
                    response.EnsureSuccessStatusCode();
                    return true;
                }
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

    }
}
