using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocenka_mer_svyzei
{
    class AnalysisClass
    {
        //максимальное кол-во значений для ранговой шкалы
        public static int N = 7;

        //максимальный объем выборки при использовании КК Спирмена
        public static int SPEARMAN_SIZE = 30;

        public static string getDataScale(int valuesCount)
        {
            if (valuesCount == 2)
            {
                return "дихотомическая";
            }
            else if (valuesCount > 2 && valuesCount <= N)
            {
                return "ранговая";
            } else if (valuesCount > N)
            {
                return "количественная";
            }

            return "невозможно определить шкалу";
        }

        public static string getDistribution(bool significant)
        {
            if (significant)
            {
                return "не нормальное";
            }
            return "нормальное";
        }

        public static string getCorrelationCoefficients(string scaleX, string distrX, string scaleY, string distrY, int sampleCount)
        {
            if (scaleX.Equals("дихотомическая"))
            {
                if (scaleY.Equals("дихотомическая"))
                {
                    return "хи квадрат Пирсона, Фишера, Крамера, Гудмена-Крускала";
                }
                else if (distrY.Equals("нормальное"))
                {
                    if (scaleY.Equals("ранговая"))
                    {
                        return "Рангово-бисериальный";
                    }
                    else if (scaleY.Equals("количественная"))
                    {
                        return "Точечно-бисериальный, бисериальный";
                    }
                }
            }
            else if (scaleX.Equals("ранговая"))
            {
                if (distrX.Equals("нормальное"))
                {
                    if (scaleY.Equals("дихотомическая"))
                    {
                        return "Рангово-бисериальный";
                    }
                    else if (distrY.Equals("нормальное"))
                    {
                        if (scaleY.Equals("ранговая"))
                        {
                            return "тау Кендалла";
                        }
                        else if (scaleY.Equals("количественная") 
                            && sampleCount <= SPEARMAN_SIZE)
                        {
                            return "Спирмена";
                        }
                    }
                }
                else if ((sampleCount <= SPEARMAN_SIZE) 
                    && scaleY.Equals("ранговая") || scaleY.Equals("количественная"))
                {
                    return "Спирмена";
                }
            }
            else if(scaleX.Equals("количественная"))
            {
                if (distrX.Equals("нормальное"))
                {

                    if (scaleY.Equals("дихотомическая"))
                    {
                        return "Точечно-бисериальный, бисериальный";
                    }
                    else if (distrY.Equals("нормальное"))
                    {
                        if (scaleY.Equals("количественная"))
                        {
                            return "Пирсона";
                        }
                        else if (sampleCount <= SPEARMAN_SIZE && scaleY.Equals("ранговая"))
                        {
                            return "Спирмена";
                        }
                    }
                    else
                    {
                        if(sampleCount <= SPEARMAN_SIZE)
                        {
                            return "Спирмена";
                        }
                    }
                }
            }

            return "не применимы";
        }


        static Random rnd = new Random();

        public static double[] generateSample(string scale, string distr, int size)
        {

            List<double> sample = new List<double>(size);
            if (scale.Equals("дихотомическая"))
            {
                for (int i = 0; i < size; i++)
                {
                    sample.Add(rnd.Next(2));
                }
            }
            else if (scale.Equals("ранговая"))
            {
                if (distr.Equals("нормальное"))
                {
                    //MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 5);
                    rnd.Next(7);
                    List<double> smp = new List<double>(size);

                    for (int i = 0; i < size; i++)
                    {
                        smp.Add(rnd.Next(7));
                    }

                    MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 1);

                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(Math.Ceiling(nDistr.Sample()));
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(rnd.Next(7));
                    }

                }

            }
            else if (scale.Equals("количественная"))
            {
                if (distr.Equals("нормальное"))
                {
                    MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 2);
                    double[] arr = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        MathNet.Numerics.Distributions.Normal.Samples(arr, 0, 1);
                        sample = arr.ToList();
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(rnd.NextDouble() * 10);
                    }

                }
            }
            return sample.ToArray();
        }


    }
}
