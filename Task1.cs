using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public interface IOutput
    {
        public void Show();
        public void Show(String info);
    }
    internal class Task1
    {
        public void TestTask1()
        {
            MyArray myArray = new MyArray();
            myArray.Show();
            myArray.Show("three number myIntArray");
        }
    }
}
