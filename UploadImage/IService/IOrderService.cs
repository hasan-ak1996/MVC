using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadImage.Models;

namespace UploadImage.IService
{
     public interface IOrderService
    {
        OrderTest save(OrderTest order);
        OrderTest GetSavedOrder();
    }
}
