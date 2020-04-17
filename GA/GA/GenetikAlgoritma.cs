using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    public class GenetikAlgoritma
    {


        private readonly Random rnd = new Random();
        public List<double> GenAl(int _as, int us, int d, int psize, double caprazlamaOlasilik, double mutasyonOlasilik, int iterasyon)
        {
            List<double> eniyidegrler = new List<double>();
            double eniyideger = 99990;
            double temp;
            double[,] populasyon = new double[psize, d];
            double[,] arapopulasyon;
            double[,] caprazlanmispopulasyon;
            double[,] mutasyonpopulasyon;
            double[] amacFonksiyonDegeri;
            double[,] guclunesil = new double[psize / 2, d];
            for (int i = 0; i < psize; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    while (true)
                    {
                        temp = rnd.Next(_as, us) * rnd.NextDouble()
                            ;
                        if (temp > _as && temp < us)
                        {
                            break;
                        }
                    }
                    populasyon[i, j] = temp;
                }
            }
            for (int i = 0; i < iterasyon; i++)
            {
                amacFonksiyonDegeri = AmacFonksiyon(populasyon, psize, d);
                for (int k = 0; k < amacFonksiyonDegeri.Length; k++)
                {
                    eniyideger = 99990;
                    if (amacFonksiyonDegeri[k] < eniyideger)
                    {
                        eniyideger = amacFonksiyonDegeri[k];
                    }
                }
                eniyidegrler.Add(eniyideger);
                arapopulasyon = DogalSecilim(populasyon, amacFonksiyonDegeri, psize, d);
                caprazlanmispopulasyon = Caprazlama(arapopulasyon, psize, d, caprazlamaOlasilik);
                mutasyonpopulasyon = Mutasyon(caprazlanmispopulasyon, psize, d, mutasyonOlasilik);
                populasyon = mutasyonpopulasyon;
            }
            return eniyidegrler;
        }
        public double[] AmacFonksiyon(double[,] populasyon, int psize, int d)
        {
            double[] amacFonksiyonDegeri = new double[psize];
            for (int i = 0; i < psize; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    amacFonksiyonDegeri[i] += populasyon[i, j] * populasyon[i, j];

                }
            }
            return amacFonksiyonDegeri;
        }
        public double[,] DogalSecilim(double[,] populasyon, double[] amacFonksiyonDegeri, int psize, int d)
        {
            double sifirBirArasiRandom;
            double toplam = 0;
            double[] olasılıkDegerleri = new double[psize];
            double[] hayattaKalmaOlasılıkDegerleri = new double[psize];
            int[] index = new int[psize];
            double[,] arapopulasyon = new double[psize, d];
            for (int i = 0; i < psize; i++)
            {
                amacFonksiyonDegeri[i] = (1 / amacFonksiyonDegeri[i]);
            }
            for (int i = 0; i < psize; i++)
            {
                toplam += amacFonksiyonDegeri[i];

            }
            for (int p = 0; p < psize; p++)
            {
                olasılıkDegerleri[p] = amacFonksiyonDegeri[p] / toplam;
            }
            hayattaKalmaOlasılıkDegerleri[0] = olasılıkDegerleri[0];
            for (int i = 1; i < psize; i++)
            {
                hayattaKalmaOlasılıkDegerleri[i] = olasılıkDegerleri[i] + hayattaKalmaOlasılıkDegerleri[i - 1];
            }
            for (int i = 0; i < psize; i++)
            {
                sifirBirArasiRandom = rnd.NextDouble();
                int j = 0;
                for (; j < psize; j++)
                {
                    if (sifirBirArasiRandom < hayattaKalmaOlasılıkDegerleri[j])
                    {
                        index[i] = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < psize; i++)
            {
                for (int k = 0; k < d; k++)
                {
                    arapopulasyon[i, k] = populasyon[index[i], k];
                }
            }
            return arapopulasyon;
        }
        public double[,] Caprazlama(double[,] populasyon, int psize, int d, double caprazlamaOlasiligi)
        {
            int random1;
            int random2;
            int temp;
            int ebeveynIndex1;
            int ebeveynIndex2;
            double capOlasRandom;
            int kesme = rnd.Next(1, d); ;
            double[] tempDizi = new double[kesme];
            int[] index = new int[psize];
            double[,] caprazlanmispopulasyon = new double[psize, d];
            for (int i = 0; i < psize; i++)
            {
                index[i] = i;
            }
            for (int i = 0; i < psize * 2; i++)
            {
                random1 = rnd.Next(psize);
                random2 = rnd.Next(psize);
                temp = index[random1];
                index[random1] = index[random2];
                index[random2] = temp;
            }
            for (int i = 0; i < psize / 2; i++)
            {
                ebeveynIndex1 = index[2 * i];
                ebeveynIndex2 = index[2 * i + 1];
            }
            for (int i = 0; i < psize / 2; i++)
            {
                capOlasRandom = rnd.NextDouble();
                if (capOlasRandom < caprazlamaOlasiligi)
                {
                    for (int y = 0; y < kesme; y++)
                    {
                        tempDizi[y] = populasyon[index[2 * i], y];
                    }
                    for (int y = 0; y < kesme; y++)
                    {
                        populasyon[index[2 * i], y] = populasyon[index[2 * i + 1], y];
                    }
                    for (int y = 0; y < kesme; y++)
                    {
                        populasyon[index[2 * i + 1], y] = tempDizi[y];
                    }
                }
            }
            for (int i = 0; i < psize; i++)
            {
                for (int j = 0; j < d; j++)
                {

                    caprazlanmispopulasyon[i, j] = populasyon[index[i], j];
                }
            }
            return caprazlanmispopulasyon;
        }
        public double[,] Mutasyon(double[,] populasyon, int psize, int d, double mutasyonOlasiligi)
        {

            double random;
            for (int i = 0; i < psize; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    random = rnd.NextDouble();
                    if (random < mutasyonOlasiligi)
                    {
                        if (random < 0.5)
                        {
                            populasyon[i, j] -= 0.79;
                        }
                        else
                        {
                            populasyon[i, j] -= 0.57;
                        }
                    }
                }
            }
            return populasyon;
        }
       
    }
}
