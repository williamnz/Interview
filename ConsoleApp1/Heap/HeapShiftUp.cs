using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Heap
{
    public class HeapShiftUp<T> where T: IComparable
    {
        public T[] Data;
        protected int Count;
        protected int Capacity;
        public  HeapShiftUp(int capacity)
        {
            Data = new T[capacity+1];
            Count = 0;
            this.Capacity = capacity;
        }
        public int Size()
        {
            return Count;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
        public void Insert(T item)
        {
            if (Count + 1 <= Capacity)
            {
                Data[Count + 1] = item;
                Count++;
                ShiftUp(Count);
            }
            else
            {
                throw new Exception("超出最大容量");
            }
        }
        private void Swap(int i, int j)
        {
            T t = Data[i];
            Data[i] = Data[j];
            Data[j] = t;
        }

        private void ShiftUp(int k)
        {
            while (k > 1 && Data[k / 2].CompareTo(Data[k]) < 0)
            {
                Swap(k, k / 2);
                k /= 2;
            }
        }
        

        
    }
}
