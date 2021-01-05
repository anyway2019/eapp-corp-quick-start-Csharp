using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using eapp_corp_quick_start_Csharp.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eapp_corp_quick_start_Csharp.utils
{
    public class AccessTokenUtils
    {
        public static string GetToken()
        {
            try
            {
                DefaultDingTalkClient client = new DefaultDingTalkClient(URLConstant.URL_GET_TOKKEN);
                OapiGettokenRequest request = new OapiGettokenRequest
                {
                    Appkey = Constants.APP_KEY,
                    Appsecret = Constants.APP_SECRET
                };

                request.SetHttpMethod("GET");
                OapiGettokenResponse response = client.Execute(request);
                string accessToken = response.AccessToken;
                return accessToken;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
