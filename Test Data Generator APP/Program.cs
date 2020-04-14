using System;
using TestDataGeneratorLibrary;

namespace Test_Data_Generator_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person dudeOne = new Person("Pekka", "Paavola", 54);

            Console.WriteLine(dudeOne.getData());
        }
    }
}
