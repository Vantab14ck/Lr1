namespace CarLibrary
{
    public class Automobile
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double EngineVolume { get; set; }
        public int CurrentSpeed { get; private set; }

        public Automobile(string type, string brand, string color, double engineVolume)
        {
            Type = type;
            Brand = brand;
            Color = color;
            EngineVolume = engineVolume;
            CurrentSpeed = 0;
        }

        public void Accelerate(int speedChange)
        {
            CurrentSpeed += speedChange;
        }

        public void Decelerate(int speedChange)
        {
            CurrentSpeed -= speedChange;
        }
    }
}
