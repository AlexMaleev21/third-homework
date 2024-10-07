using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class Task3
    {
        public void TestTask3()
        {
            MyArray myArray = new MyArray();
            myArray.SortAsc();
            myArray.PrintArray();
            myArray.SortDesc();
            myArray.PrintArray();
            myArray.SortByParam(false);
            myArray.PrintArray();
        }
    }

    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
