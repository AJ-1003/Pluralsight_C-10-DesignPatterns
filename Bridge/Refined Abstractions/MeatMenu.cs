using Bridge.Abstraction;
using Bridge.Implementor;

namespace Bridge.Refined_Abstractions
{
    public class MeatMenu : Menu
    {
        public MeatMenu(ICoupon coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }
}
