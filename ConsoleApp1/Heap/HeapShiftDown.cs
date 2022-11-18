using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Heap
{
    public class HeapShiftDown<T> where T: IComparable
    {
        public T[] Data;
        protected int Count;
        protected int Capacity;
        public  HeapShiftDown(int capacity)
        {
            Data = new T[capacity+1];
            Count = 0;
            this.Capacity = capacity;
        }
        /// <summary>
        /// 返回堆中的元素个数
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Count;
        }
        /// <summary>
        /// 返回一个布尔值, 表示堆中是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }
        /// <summary>
        /// 像最大堆中插入一个新的元素 item
        /// </summary>
        /// <param name="item"></param>
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
        /// <summary>
        /// 从最大堆中取出堆顶元素, 即堆中所存储的最大数据
        /// </summary>
        /// <returns></returns>
        public T ExtractMax()
        {
            if(Count>0)
            {
                T ret = Data[1];
                Swap(1, Count);
                Count--;
                ShiftDown(1);
                return ret;
            }
            else
            {
                throw new Exception("无数组数据");
            }
        }
        public T GetMax()
        {
            if (Count > 0)
                return Data[1];
            else
                throw new Exception("无数组数据");

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
        private void ShiftDown(int k)
        {
            while (2 * k <= Count)
            {
                int j = 2 * k;//在此轮循环中,Data[k]和Data[j]交换位置
                if (j + 1 <= Count && Data[j + 1].CompareTo(Data[j]) > 0)
                    j++;
                //Data[j]是 Data[2*k]和Data[2*k+1]中的最大值
                if (Data[k].CompareTo(Data[j]) >= 0) break;
                Swap(k, j);
                k = j;
            }
        }        
    }
}
