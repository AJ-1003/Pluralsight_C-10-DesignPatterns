using Bridge.Implementor;

namespace Bridge.Concrete_Implementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }
}
