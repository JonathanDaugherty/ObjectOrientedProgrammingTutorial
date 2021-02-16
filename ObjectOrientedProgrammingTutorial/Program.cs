using System;

namespace ObjectOrientedProgrammingTutorial {
    class Program {
        static void Main(string[] args) {

            var sqr1 = new Sqr(7);
            Console.WriteLine($"sqr1 perimeter is {sqr1.Perimeter()}, sqr1 area is {sqr1.Area()}");
            var rect1 = new Rect(5, 7);
            Console.WriteLine($"Rect1 perimeter is {rect1.Perimeter()}");
            //Console.WriteLine($"About is {rect1.About}");
            Console.WriteLine($"Rect1 area is {rect1.Area()}");
            
        }
    }
}
