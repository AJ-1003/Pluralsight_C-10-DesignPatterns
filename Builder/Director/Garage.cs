using Builder.Builder;

namespace Builder.Director
{
    /// <summary>
    /// Director
    /// </summary>
    public class Garage
    {
        private CarBuilder? _carBuilder;

        public Garage()
        {

        }

        public void Construct(CarBuilder builder)
        {
            _carBuilder = builder;

            _carBuilder.BuildEngine();
            _carBuilder.BuildFrame();
        }

        public void Show()
        {
            Console.WriteLine(_carBuilder.Car.ToString());
        }
    }
}
