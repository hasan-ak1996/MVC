using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using UploadImage.IService;
using UploadImage.Models;

namespace UploadImage.Controllers
{
    public class HomeController : Controller
    {
        IOrderService _orderService = null;

        public HomeController( IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public string SaveFile(FileUpload fileObj)
        {
            OrderTest order = JsonConvert.DeserializeObject<OrderTest>(fileObj.Order);
            if(fileObj.file.Length > 0)
            {
                using ( var ms = new MemoryStream() )
                {
                    fileObj.file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    order.Photo = fileBytes;
                    order = _orderService.save(order);
                    if(order.OrderTestId > 0)
                    {
                        return "saved";
                    }
                }
            }
            return "Faild";
        }
        

        [HttpGet]
        public JsonResult GetSavedOrder()
        {
            var order = _orderService.GetSavedOrder();
            order.Photo = this.GetImage(Convert.ToBase64String(order.Photo));
            return Json(order);
        }
        public byte[] GetImage(string sBase64String)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase64String))
            {
                bytes = Convert.FromBase64String(sBase64String);
            }
            return bytes;
        }
    }
}
