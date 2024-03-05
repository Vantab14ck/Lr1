using System;
using CarLibrary;

class Program
{
    static void Main(string[] args)
    {
        CargoTruck cargoTruck = new CargoTruck("Volvo", "Red", 5.0, 2000);
        PassengerCar passengerCar = new PassengerCar("Toyota", "Blue", 2.5, 5);

        Console.WriteLine($"Cargo Truck: {cargoTruck.Brand}, Payload Capacity: {cargoTruck.PayloadCapacity} kg, Color: {cargoTruck.Color}, Engine: {cargoTruck.EngineVolume}");
        Console.WriteLine($"Passenger Car: {passengerCar.Brand}, Passenger Capacity: {passengerCar.PassengerCapacity}, Color: {passengerCar.Color},Engine: {passengerCar.EngineVolume}");

        passengerCar.Accelerate(20);
        Console.WriteLine($"Passenger Car Current Speed: {passengerCar.CurrentSpeed}");
        passengerCar.Decelerate(10);
        Console.WriteLine($"Passenger Car Current Speed: {passengerCar.CurrentSpeed}");
    }
}