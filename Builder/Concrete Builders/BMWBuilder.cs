using Builder.Builder;

namespace Builder.Concrete_Builders
{
    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("Inline 5 cylinder");
        }

        public override void BuildFrame()
        {
            Car.AddPart("Reinforced alloy");
        }
    }
}
