using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var newArray = new int[5];

            var newArray2 = new int[5] { 1, 2, 3, 4, 5 };

            var newStructArray = new Test[3]{new Test(), new Test(), new Test()};
            newArray[0] = 10;

            Console.WriteLine(newArray[0]);
            Console.WriteLine(newArray2[3]);
            Console.WriteLine(newArray2.Length);

            //Console.WriteLine(newStructArray[3]);

            // foreach (var index in newArray2)
            // {
            //     Console.WriteLine(index);
            // } 

            // for (var index = 0; index < newArray2.Length ; index++)
            // {
            //     Console.WriteLine(newArray2[index]);
            // }

            var employees = new Employee[3];
            employees[0] = new Employee() { Id = Guid.NewGuid() };
            employees[1] = new Employee() { Id = Guid.NewGuid() };
            employees[2] = new Employee() { Id = Guid.NewGuid() };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id);
            }
        }

        struct Test
        {
            public int Id { get; set; }
        }
    }

    public struct Employee
    {
        public Guid Id { get; set; }
    }
}
