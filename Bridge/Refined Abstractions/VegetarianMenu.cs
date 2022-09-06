using Bridge.Abstraction;
using Bridge.Implementor;

namespace Bridge.Refined_Abstractions
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class VegetarianMenu : Menu
    {
        public VegetarianMenu(ICoupon coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }
}
