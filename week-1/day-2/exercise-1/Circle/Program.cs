namespace Circle
{      
    internal class Program
    {     public class Circle {
        private int radius;
        public Circle(int radius) {
            this.radius = radius;
        }
        public double CalculateArea() {
            return Math.PI * radius * radius;
        }
        public double CalculateCircumference() {
            return 2 * Math.PI * radius;
        }
    }
        static void Main(string[] args)
        {
            // Create a Circle object and display its area and circumference
            Circle circle = new Circle(3);
            double circumference = circle.CalculateCircumference();
            double area = circle.CalculateArea();
            Console.WriteLine("area :" + area + "perimeter :" + circumference);
        }
    }
}