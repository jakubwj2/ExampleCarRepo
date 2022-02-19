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

        public void startCar()
        {
            Console.WriteLine(this.name + " goes brrr");
        }

        public void crashCar()
        {
            Console.WriteLine("Your " + this.name + " crashed in a tree");
        }

        public void tyrePuncture()
        {
            Console.WriteLine(this.name + " punctured a tyre");
        }
    }
}
