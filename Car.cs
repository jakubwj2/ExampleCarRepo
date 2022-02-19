namespace ExampleCarRepo
{
    public class Car
    {
        public string name { get; set; }
        public int maxSpeed { get; set; }

        public Car(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }
    }
}
