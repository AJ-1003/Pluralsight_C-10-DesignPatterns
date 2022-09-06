using Bridge.Implementor;

namespace Bridge.Concrete_Implementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class TwoEuroCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}
