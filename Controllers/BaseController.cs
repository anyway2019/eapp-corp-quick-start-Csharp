using Microsoft.AspNetCore.Mvc;

namespace eapp_corp_quick_start_Csharp.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult SuccessResult(object data = null)
        {
            return JsonResult(200, data, null);
        }

        protected IActionResult FailResult(object data, string message)
        {
            return JsonResult(-1, data, message);
        }

        protected IActionResult FailResult(string message)
        {
            return JsonResult(-1, null, message);
        }

        protected IActionResult JsonResult(object data, string message)
        {
            return JsonResult(200, data, message);
        }

        protected IActionResult JsonResult(int code, object data, string message = "")
        {
            return Json(new JsonResultModel<object>
            {
                code = code,
                data = data,
                message = message
            });
        }
        public class JsonResultModel<T>
        {

            public int code { get; set; }
            public T data { get; set; }
            public string message { get; set; }

        }
    }
}
