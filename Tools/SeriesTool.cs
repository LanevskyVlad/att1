using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class SeriesTool
    {
        public List<double> Series { get; set; }
        public SeriesTool(List<double> series) => Series = series;
        public List<int> GetSeriesLength(int type)
        {
            List<int> Lengths = new List<int>();
            if (Series.Count != 0)
            {
                int count = 1;
                double last = Series[0];
                for (int i = 1; i < Series.Count; i++)
                {
                    switch (type)
                    {
                        case 0:
                            if (Series[i] == last)
                                count++;
                            else
                            {
                                if (count != 1)
                                    Lengths.Add(count);
                                count = 1;
                                last = Series[i];
                            }
                            break;
                        case 1:
                            if (Series[i] > last)
                                count++;
                            else
                            {
                                if (count != 1)
                                    Lengths.Add(count);
                                count = 1;
                            }
                            last = Series[i];
                            break;
                        case 2:
                            if (Series[i] < last)
                                count++;
                            else
                            {
                                if (count != 1)
                                    Lengths.Add(count);
                                count = 1;
                            }
                            last = Series[i];
                            break;
                    }
                }

                if (count != 1)
                    Lengths.Add(count);
            }
            return Lengths;
        }
        public List<int> GetMonotonSeriesLength() => GetSeriesLength(0);
        public List<int> GetIncreasesSeriesLength() => GetSeriesLength(1);
        public List<int> GetDecreasesSeriesLength() => GetSeriesLength(2);
    }
}
