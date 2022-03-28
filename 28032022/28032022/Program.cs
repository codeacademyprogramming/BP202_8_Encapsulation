using System;

namespace _28032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adi daxil edin:");
            string fullname = Console.ReadLine();

            byte age;

                Console.WriteLine("Yasi daxil edin");
                string ageStr = Console.ReadLine();
                age = Convert.ToByte(ageStr);

          

            Human human = new Human("Baki")
            {
                FullName = fullname,
                Age = age,
            };
            //human.AgeSetter(age);


            Console.WriteLine(human.GetInfo());
            Console.WriteLine(human.Age);

            Console.WriteLine(human.BornCity);


            Car car = new Car(45);
            car.Model = "A";
            car.Model = "Cayen";

            car.Drive(40);


            Employee employee = new Employee(45,"Shaki");
            Console.WriteLine(car.GlobalMillage);

            Student student = new Student();
            student.GroupNo = "BP202";

            Console.WriteLine(student.GroupNo);
        }
    }
}
