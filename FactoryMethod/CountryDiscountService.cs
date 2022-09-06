namespace FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    // if you are from Belgium, you get better discount
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }
}
