namespace CarLibrary
{
    public class CargoTruck : Automobile
    {
        public double PayloadCapacity { get; set; }

        public CargoTruck(string brand, string color, double engineVolume, double payloadCapacity)
            : base("Cargo Truck", brand, color, engineVolume)
        {
            PayloadCapacity = payloadCapacity;
        }
    }
}