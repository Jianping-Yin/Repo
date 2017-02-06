using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Due0119Assign0117.NewFolder1
{
    class Process1
    {
        private List<double> numbers;


        public Process1(List<double> numbers)
        {
            this.numbers = numbers;
        }

        //public List<double> Numbers
        //{
        //    get
        //    {
        //        return numbers;
        //    }

        //    set
        //    {
        //        numbers = value;
        //    }
        //}

        public double GetSum()
        {
            double sum = 0.0;
            foreach (double num in numbers)
            {
                sum = sum + num;
            }
            return sum;

        }

        public double GetMean()
        {
            if (numbers.Count() == 0)
                return 0.0;
            else
            {
                return GetSum() / numbers.Count();
            }

        }


        #region sort and getMedian
        public double GetMedian()
        {
            double temp;
            int size = numbers.Count();

            if (size == 0)
                return 0.0;
            else if (size == 1)
                return numbers[0];
            else
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }
                if ((size % 2) == 0)
                    return (numbers[size / 2 - 1] + numbers[size / 2]) / 2;
                else
                    return numbers[(size - 1) / 2];
            }
        } 
        #endregion


        public double GetMax()
        {
            double max = 0.0;
            int size = numbers.Count();
            if (size == 0)
                return 0.0;
            else if (size == 1)
                return numbers[0];
            else
            {
                max =numbers[0];
                foreach (double num in numbers)
                {
                    if (num > max) max = num;
                }
                return max;
            }

        }

        public double GetMin()
        {
            double min = 0.0;
            int size = numbers.Count();
            if (size == 0)
                return 0.0;
            else if (size == 1)
                return numbers[0];
            else
            {
                min = numbers[0];
                foreach (double num in numbers)
                {
                    if (num <min) min = num;
                }
                return min;
            }

        }
    }
}
