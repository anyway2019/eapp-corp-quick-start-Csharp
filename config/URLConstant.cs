using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eapp_corp_quick_start_Csharp.config
{
    public class URLConstant
    {
        /**
         * 钉钉网关gettoken地址
         */
        public static readonly String URL_GET_TOKKEN = "https://oapi.dingtalk.com/gettoken";

        /**
         *获取用户在企业内userId的接口URL
         */
        public static readonly String URL_GET_USER_INFO = "https://oapi.dingtalk.com/user/getuserinfo";

        /**
         *获取用户姓名的接口url
         */
        public static readonly String URL_USER_GET = "https://oapi.dingtalk.com/user/get";
    }
}
