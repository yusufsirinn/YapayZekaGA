using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace GA
{
    public partial class Form1 : Form
    {
        GenetikAlgoritma gaa = new GenetikAlgoritma();
        int altSinir = -50;
        int ustSinir = 35;
        int psize = 48;
        int d = 12;
        double caprazlamaOlasilik = 0.7;
        double mutasyonOlasilik = 0.05;
        int iterasyon = 100;

            

        public Form1()
        {
            InitializeComponent();
            numAltSin.Value = altSinir;
            numUstSin.Value = ustSinir;
            numPopulasyonBoyutu.Value = psize;
            numXn.Value = d;
            numCaprazlamaOlasilik.Value = Convert.ToDecimal(caprazlamaOlasilik);
            numMutasyonOrani.Value = Convert.ToDecimal(mutasyonOlasilik);
            numIterasyon.Value = iterasyon;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Eniyidegerler"].Points.Clear();

            altSinir =Convert.ToInt32(numAltSin.Value);
            ustSinir = Convert.ToInt32(numUstSin.Value);
            psize = Convert.ToInt32(numPopulasyonBoyutu.Value);
            d = Convert.ToInt32(numXn.Value);
            caprazlamaOlasilik = Convert.ToDouble(numCaprazlamaOlasilik.Value);
            mutasyonOlasilik = Convert.ToDouble(numMutasyonOrani.Value);
            iterasyon = Convert.ToInt32(numIterasyon.Value);

            List<double> eniyidegrler = gaa.GenAl(altSinir, ustSinir, d, psize, caprazlamaOlasilik, mutasyonOlasilik, iterasyon);
                
            int i = 0;
            foreach (var item in eniyidegrler)
            {
                this.chart1.Series["Eniyidegerler"].Points.AddXY(i, item);
            }
            
        }
    }
}
