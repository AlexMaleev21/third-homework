using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class Task2
    {
        public void TestTask2()
        {
            MyArray myArray = new MyArray();
            Console.WriteLine(myArray.Max());
            Console.WriteLine(myArray.Min());
            Console.WriteLine(myArray.Avg());
            Console.WriteLine(myArray.Search(2));
        }
        

    }
    public interface IMath
    {
        public int Max();
        public int Min();
        public float Avg();
        public bool Search(int valueToSearch);
    }
}
