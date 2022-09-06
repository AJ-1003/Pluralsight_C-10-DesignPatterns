using Builder.Builder;

namespace Builder.Concrete_Builders
{
    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class MiniBuilder : CarBuilder
    {
        public MiniBuilder() : base("Mini")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("Alloy");
        }
    }
}
