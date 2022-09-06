using Bridge.Implementor;

namespace Bridge.Concrete_Implementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class OneEuroCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }
}
