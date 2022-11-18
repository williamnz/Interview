using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sort
{
    public class InsertSort
    {
        /// <summary>
        /// 插入排序核心代码
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(IComparable[] arr)
        {
            int n = arr.Length;
            for(int i=0;i<n; i++)
            {
                //寻找元素 arr[i] 合适的插入位置
                for (int j=i;j>0;j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                        swap(arr, j, j - 1);
                    else
                        break;
                }
            }
        }
        private void swap(Object[] arr, int i, int j)
        {
            Object t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

    }
}
