using MrCMS.Web.Apps.Ecommerce.Models;

namespace MrCMS.Web.Apps.Ecommerce.Services.Cart
{
    public interface ICartDiscountService
    {
        CheckCodeResult AddDiscountCode(string discountCode);
        void RemoveDiscountCode(string discountCode);
    }
}