using DoAN_k4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Area("SocialUser")]
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
                    var loggedInUserId = HttpContext.Session.GetString("UserLogin");
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
                    var loggedInUserId = HttpContext.Session.GetString("UserLogin");
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
        public async Task<IActionResult> Detail(string userId)
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
                    var loggedInUserId = HttpContext.Session.GetString("UserLogin");

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
        public async Task<IActionResult> Update(string id, string fName, string lName, string phone, string email, string about, IFormFile avatar,string img)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    
                    string imageUrl = "";

                    if (avatar != null)
                    {
                        // Gửi ảnh lên API để upload
                        var formData = new MultipartFormDataContent();
                        formData.Add(new StreamContent(avatar.OpenReadStream()), "image", avatar.FileName);

                        var uploadResponse = await httpClient.PostAsync(urlConnectApi + "upload", formData);
                        if (!uploadResponse.IsSuccessStatusCode)
                        {
                            return BadRequest("Failed to upload image.");
                        }

                        var uploadResult = await uploadResponse.Content.ReadAsStringAsync();
                        var filename = JsonConvert.DeserializeObject<dynamic>(uploadResult).filename;
                        imageUrl = "http://10.0.2.2:3000/public/uploads/" + filename;

                    }
                    else
                    {
                        imageUrl = img;
                    }
                    var postData = new
                    {
                        fname=fName,
                       lname= lName,
                        userImg = imageUrl,
                        phone,about
                        ,email
                    };

                    var json = JsonConvert.SerializeObject(postData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    // Gửi request PUT để cập nhật thông tin người dùng
                    var responseUpdateUser = await httpClient.PutAsync(urlConnectApi+"users/"+id, content);

                    if (responseUpdateUser.IsSuccessStatusCode)
                    {
                        // Chuyển hướng đến action "Detail" để hiển thị thông tin người dùng sau khi cập nhật
                        return RedirectToAction("Detail", new { userId = id });
                    }
                    else
                    {
                        // Xử lý khi cập nhật không thành công
                        return View("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý khi có lỗi trong quá trình kết nối API hoặc xử lý dữ liệu
                return View("Error : " + ex.Message);
            }
        }

    }
}
