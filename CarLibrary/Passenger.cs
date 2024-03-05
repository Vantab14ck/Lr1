namespace CarLibrary
{
    public class PassengerCar : Automobile
    {
        public int PassengerCapacity { get; set; }

        public PassengerCar(string brand, string color, double engineVolume, int passengerCapacity)
            : base("Passenger Car", brand, color, engineVolume)
        {
            PassengerCapacity = passengerCapacity;
        }
    }
}