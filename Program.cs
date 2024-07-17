using StructvsClassDemo.Models;
namespace StructvsClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StructureDem car1;      //structure declaration
            car1.Brand = "Hyundai";
            car1.Model = "Verna";
            car1.Color = "Blue";
            Console.WriteLine($"Name of brand: {car1.Brand} \n" + 
                           $"Model name: {car1.Model} \n" + 
                           $"Color of car: {car1.Color}" );


            ClassDem car2= new ClassDem("Honda", "City", "Black");  //objext Declaration
            Console.WriteLine($"Name of brand: {car2.Brand} \n" +
                        $"Model name: {car2.Model} \n" +
                        $"Color of car: {car2.Color}");


            ///explaining value type and reference nature between struct and classes
            ///
            StructureDem car3 = new StructureDem();
            car3.id = 101;
            StructureDem car5 = car3;
            Console.WriteLine("car3 Id before: "+car3.id);
            Console.WriteLine("car5 Id before: " + car5.id);

            Console.WriteLine(car3.GetHashCode());   //both have same hashcodes
            Console.WriteLine(car5.GetHashCode());
            

            car5.id = 104;
            Console.WriteLine("car3 Id after: " + car3.id);
            Console.WriteLine("car5 Id after: " + car5.id);

            Console.WriteLine(car3.GetHashCode());   //both have different hashcodes
            Console.WriteLine(car5.GetHashCode());



            Console.WriteLine("---------------------------------------");

            ClassDem car4 = new ClassDem(101);
            ClassDem car6 = car4;

            Console.WriteLine("car4 Id before: " + car4.Id);
            Console.WriteLine("car6 Id before: " + car6.Id);

            Console.WriteLine(car4.GetHashCode());   //they have same hashcodes even before change
            Console.WriteLine(car6.GetHashCode());

            car6.Id = 102;


            Console.WriteLine("car4 Id after: " + car4.Id);
            Console.WriteLine("car6 Id after: " + car6.Id);

            Console.WriteLine(car4.GetHashCode());   //they have same hashcodes even after change
            Console.WriteLine(car6.GetHashCode());
        }
    }
}
