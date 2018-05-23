using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class RookPosition
    {
        private List<int[]> list = new List<int[]>();
        private int[] arr = new int[8];
        private void SetPositions(int index)
        {
            if (index == 8)
                list.Add((int[])arr.Clone());
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    bool t = true;
                    for (int j = 0; j < index; j++)
                        if(arr[j] == i)
                        {
                            t = false;
                            break;
                        }
                    if(t)
                    {
                        arr[index] = i;
                        SetPositions(index + 1);
                    }
                }
            }
        }
        public List<int[]> GetPositions()
        {
            if (list.Count == 0)
                SetPositions(0);
            return list;
        }
    }
}
