using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Student
    {
        public string FIO { get; set; }
        public DateTime Year { get; set; }
        public List<double> MedB { get; set; }
        public Byte Kurs { get; set; }
        public Byte Group { get; set; }

        public Student(string fIO, DateTime year, List<double> medB, byte kurs, byte group)
        {
            FIO = fIO;
            Year = year;
            MedB = medB;
            Kurs = kurs;
            Group = group;
        }

        public static double[] AvgB(List<Student> list)
        {
            double[] avgB = new double[7];
            int[] count = new int[7];
            for (int i = 0; i < list.Count; i++)
            {
                count[list[i].Kurs - 1] += list[i].MedB.Count;
                for (int j = 0; j < list[i].MedB.Count; j++)
                    avgB[list[i].Kurs-1] += list[i].MedB[j];
            }
            for (int i = 0; i < 7; i++)
                if (count[i] != 0)
                    avgB[i] /= count[i];
            return avgB;
        }
    }
}
