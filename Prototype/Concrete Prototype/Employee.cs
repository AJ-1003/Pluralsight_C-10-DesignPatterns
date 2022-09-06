using Newtonsoft.Json;

using Prototype.Prototype;

namespace Prototype.Concrete_Prototype
{
    /// <summary>
    /// ConcretePrototype
    /// </summary>
    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(objectAsJson);
            }
            return (Person)MemberwiseClone();
        }
    }
}
