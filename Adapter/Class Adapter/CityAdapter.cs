namespace Adapter.Class_Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            // call into the external system
            var cityFromExternalSystem = base.GetCity();

            // adapt the cityFromExternalSystem to a City
            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);
        }
    }
}
