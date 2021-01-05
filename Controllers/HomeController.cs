using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using eapp_corp_quick_start_Csharp.utils;
using eapp_corp_quick_start_Csharp.config;

namespace eapp_corp_quick_start_Csharp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult test()
        {
            return SuccessResult("test");
        }
        [HttpPost]
        public IActionResult login(string authCode)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/getuserinfo");
            OapiUserGetuserinfoRequest req = new OapiUserGetuserinfoRequest();
            req.Code = authCode;
            req.SetHttpMethod("GET");
            var access_token = AccessTokenUtils.GetToken();
            OapiUserGetuserinfoResponse response = client.Execute(req, access_token);

            string userId = response.Userid;
            string userName = getUserName(access_token, userId);

            return SuccessResult(new { userId, userName });
        }

        private string getUserName(string accessToken, string userId)
        {
            try
            {
                IDingTalkClient client = new DefaultDingTalkClient(URLConstant.URL_USER_GET);
                OapiUserGetRequest request = new OapiUserGetRequest();
                request.Userid = userId;
                request.SetHttpMethod("GET");
                OapiUserGetResponse response = client.Execute(request, accessToken);
                return response.Name;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
