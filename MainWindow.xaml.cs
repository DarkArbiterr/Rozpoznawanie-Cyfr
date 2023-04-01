using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace perceptron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] data = new double[] {  0,0,0,0,0,
                                        0,0,0,0,0,
                                        0,0,0,0,0,
                                        0,0,0,0,0,
                                        0,0,0,0,0,
                                        0,0,0,0,0,
                                        0,0,0,0,0};
        double[] thetaArray = new double[10];
        double[] perceptron0;
        double[] perceptron1;
        double[] perceptron2;
        double[] perceptron3;
        double[] perceptron4;
        double[] perceptron5;
        double[] perceptron6;
        double[] perceptron7;
        double[] perceptron8;
        double[] perceptron9;
        public MainWindow()
        {
            InitializeComponent();
            foreach (var btn in buttons.Children.OfType<Button>())
                btn.Background = Brushes.Black;
            perceptron0 = Simple_Perceptron_Learning(0);
            perceptron1 = Simple_Perceptron_Learning(1);
            perceptron2 = Simple_Perceptron_Learning(2);
            perceptron3 = Simple_Perceptron_Learning(3);
            perceptron4 = Simple_Perceptron_Learning(4);
            perceptron5 = Simple_Perceptron_Learning(5);
            perceptron6 = Simple_Perceptron_Learning(6);
            perceptron7 = Simple_Perceptron_Learning(7);
            perceptron8 = Simple_Perceptron_Learning(8);
            perceptron9 = Simple_Perceptron_Learning(9);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {

        }

        //Wypelnianie matrycy wejsciowej (wyklikanej na ekranie)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name == "b00")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[0] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[0] = 1;
                }      
            }
            if (((Button)sender).Name == "b01")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[1] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[1] = 1;
                }
            }
            if (((Button)sender).Name == "b02")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[2] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[2] = 1;
                }
            }
            if (((Button)sender).Name == "b03")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[3] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[3] = 1;
                }
            }
            if (((Button)sender).Name == "b04")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[4] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[4] = 1;
                }
            }
            if (((Button)sender).Name == "b10")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[5] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[5] = 1;
                }
            }
            if (((Button)sender).Name == "b11")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[6] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[6] = 1;
                }
            }
            if (((Button)sender).Name == "b12")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[7] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[7] = 1;
                }
            }
            if (((Button)sender).Name == "b13")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[8] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[8] = 1;
                }
            }
            if (((Button)sender).Name == "b14")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[9] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[9] = 1;
                }
            }
            if (((Button)sender).Name == "b20")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[10] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[10] = 1;
                }
            }
            if (((Button)sender).Name == "b21")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[11] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[11] = 1;
                }
            }
            if (((Button)sender).Name == "b22")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[12] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[12] = 1;
                }
            }
            if (((Button)sender).Name == "b23")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[13] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[13] = 1;
                }
            }
            if (((Button)sender).Name == "b24")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[14] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[14] = 1;
                }
            }
            if (((Button)sender).Name == "b30")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[15] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[15] = 1;
                }
            }
            if (((Button)sender).Name == "b31")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[16] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[16] = 1;
                }
            }
            if (((Button)sender).Name == "b32")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[17] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[17] = 1;
                }
            }
            if (((Button)sender).Name == "b33")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue) 
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[18] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[18] = 1;
                }
            }
            if (((Button)sender).Name == "b34")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[19] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[19] = 1;
                }
            }
            if (((Button)sender).Name == "b40")
            {
                if (((Button)sender).Background == Brushes.HotPink)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[20] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[20] = 1;
                }
            }
            if (((Button)sender).Name == "b41")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[21] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[21] = 1;
                }
            }
            if (((Button)sender).Name == "b42")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[22] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[22] = 1;
                }
            }
            if (((Button)sender).Name == "b43")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[23] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[23] = 1;
                }
            }
            if (((Button)sender).Name == "b44")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[24] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[24] = 1;
                }
            }
            if (((Button)sender).Name == "b50")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[25] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[25] = 1;
                }
            }
            if (((Button)sender).Name == "b51")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[26] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[26] = 1;
                }
            }
            if (((Button)sender).Name == "b52")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[27] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[27] = 1;
                }
            }
            if (((Button)sender).Name == "b53")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[28] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[28] = 1;
                }
            }
            if (((Button)sender).Name == "b54")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[29] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[29] = 1;
                }
            }
            if (((Button)sender).Name == "b60")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[30] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[30] = 1;
                }
            }
            if (((Button)sender).Name == "b61")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[31] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[31] = 1;
                }
            }
            if (((Button)sender).Name == "b62")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[32] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[32] = 1;
                }
            }
            if (((Button)sender).Name == "b63")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[33] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[33] = 1;
                }
            }
            if (((Button)sender).Name == "b64")
            {
                if (((Button)sender).Background == Brushes.MediumSlateBlue)
                {
                    ((Button)sender).Background = Brushes.Black;
                    data[34] = 0;
                }
                else
                {
                    ((Button)sender).Background = Brushes.MediumSlateBlue;
                    data[34] = 1;
                }
            }
        }

        public double[] Simple_Perceptron_Learning(int nrPerceptron)
        {
            Data data = new Data();
            var examples = data.LoadData();
            int O;
            int lifeTime = 0;
            int bestLifeTime = 0;
            double learningEta = 0.1;
            double bestTheta = 0;
            double[] weights = new double[35];
            double[] bestWeights = new double[35];
            double max = 0.01;
            double min = -0.01;
            bool h = true;
            Random random = new Random();

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = (max - min) * random.NextDouble() + min;
            }

            double theta = (max - min) * random.NextDouble() + min;

            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(nrPerceptron);
                int rndNumber = random.Next(50);
                var example = examples[rndNumber];

                if (example.Output == nrPerceptron)
                    O = 1;
                else
                    O = -1;

                double sum = 0.0;
                int result;
                for (int j = 0; j < example.Input.Length; j++)
                {
                    sum += example.Input[j] * weights[j];
                }
                if (sum < theta)
                    result = -1;
                else
                    result = 1;

                double ERR = O - result;
                if (ERR != 0)
                {
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] = weights[j] + (learningEta * ERR * example.Input[j]);
                    }
                    theta = theta - (learningEta * ERR);
                    lifeTime = 0;
                    h = true;
                }
                else
                {
                    lifeTime++;

                        if (lifeTime > bestLifeTime)
                        {
                            bestLifeTime = lifeTime;
                            bestTheta = theta;
                        if (h == true)
                        {
                            weights.CopyTo(bestWeights, 0);
                            h = false;
                        }
                        }
                        
                    
                    
                }
            }
            thetaArray[nrPerceptron] = bestTheta;
            return bestWeights;
        }

        // zwraca przewidywana cyfre
        public void BestMatch(double[] data)
        {
            Console.Clear();
            double sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron0[i];
            }
            if (sum >= thetaArray[0])
                output.Text += "0  ";
            Console.WriteLine("Suma0: " + sum + "\tTheta0: " + thetaArray[0]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron1[i];
            }
            if (sum >= thetaArray[1])
                output.Text += "1  ";
            Console.WriteLine("Suma1: " + sum + "\tTheta1: " + thetaArray[1]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron2[i];
            }
            if (sum >= thetaArray[2])
                output.Text += "2  ";
            Console.WriteLine("Suma2: " + sum + "\tTheta2: " + thetaArray[2]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron3[i];
            }
            if (sum >= thetaArray[3])
                output.Text += "3  ";
            Console.WriteLine("Suma3: " + sum + "\tTheta3: " + thetaArray[3]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron4[i];
            }
            if (sum >= thetaArray[4])
                output.Text += "4  ";
            Console.WriteLine("Suma4: " + sum + "\tTheta4: " + thetaArray[4]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron5[i];
            }
            if (sum >= thetaArray[5])
                output.Text += "5  ";
            Console.WriteLine("Suma5: " + sum + "\tTheta5: " + thetaArray[5]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron6[i];
            }
            if (sum >= thetaArray[6])
                output.Text += "6  ";
            Console.WriteLine("Suma6: " + sum + "\tTheta6: " + thetaArray[6]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron7[i];
            }
            if (sum >= thetaArray[7])
                output.Text += "7  ";
            Console.WriteLine("Suma7: " + sum + "\tTheta7: " + thetaArray[7]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron8[i];
            }
            if (sum >= thetaArray[8])
                output.Text += "8  ";
            Console.WriteLine("Suma8: " + sum + "\tTheta8: " + thetaArray[8]);
            sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i] * perceptron9[i];
            }
            if (sum >= thetaArray[9])
                output.Text += "9  ";
            Console.WriteLine("Suma9: " + sum + "\tTheta9: " + thetaArray[9]);
        }

        private void Refresh_button(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            BestMatch(data);         
        }

    }


}

