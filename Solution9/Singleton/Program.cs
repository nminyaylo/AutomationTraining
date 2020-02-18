using System;

namespace Single
{
    class Single
    {
        public static Single instance = new Single();
        private Single() { }
    }


    class Program
    {
        static void Main()
        {
            var instanceOne = Single.instance;
            var instanceOneHash = instanceOne.GetHashCode();

            var instanceTwo = Single.instance;
            var instanceTwoHash = instanceTwo.GetHashCode();

            var equalHash = instanceOneHash == instanceTwoHash;

            Console.WriteLine($"Fifrs hash {instanceOneHash} and second hash {instanceTwoHash}. They are equal - {equalHash}");

            Console.ReadKey();


        }
    }
}
