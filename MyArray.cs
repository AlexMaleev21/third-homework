using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] myIntArray = new int[5];
        public int[] MyIntArray { get => myIntArray; set => myIntArray = value; }

        public MyArray()
        {
            MyIntArray = [7, 5, 2, 3, 8];
        }

        public void PrintArray()
        {
            Console.WriteLine(String.Join(", ", MyIntArray));
        }

        public void Show()
        {
            PrintArray();
        }

        public void Show(String info)
        {
            Console.WriteLine(String.Join(", ", MyIntArray) + ". " + info);
        }

        public int Max()
        {
            return MyIntArray.Max();
        }

        public int Min()
        {
            return MyIntArray.Min();
        }

        public float Avg()
        {
            return MyIntArray.Sum() / MyIntArray.Length;
        } 

        public bool Search(int valueToSearch)
        {
            for(int i = 0; i < MyIntArray.Length; i++)
            {
                if (MyIntArray[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(MyIntArray);
        }

        public void SortDesc()
        {
            Array.Sort(MyIntArray);
            Array.Reverse(MyIntArray);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else SortDesc();
        }
    }
}
