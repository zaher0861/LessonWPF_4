using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LessonWPF_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDoll = Convert.ToDouble(rateD.Text);
            double sumDoll = Convert.ToDouble(sumD.Text);
            double resultDoll = rateDoll * sumDoll;
            resultD.Text = resultDoll.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEu = Convert.ToDouble(rateE.Text);
            double sumEu = Convert.ToDouble(sumE.Text);
            double resultEu = rateEu * sumEu;
            resultE.Text = resultEu.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rateG.Text);
            double sumGriv = Convert.ToDouble(sumG.Text);
            double resultGriv = rateGriv * sumGriv;
            resultG.Text = resultGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArDram = Convert.ToDouble(rateAd.Text);
            double sumArDram = Convert.ToDouble(sumAd.Text);
            double resultArDram = rateArDram * sumArDram;
            resultAd.Text = resultArDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inchesInch = Convert.ToDouble(inches.Text);
            double resultInch = Math.Round(inchesInch /39.37,4);
            resultI.Text = resultInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double feetFe = Convert.ToDouble(feet.Text);
            double resultFe = Math.Round(feetFe / 3.281, 4);
            resultF.Text = resultFe.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mileMi = Convert.ToDouble(mile.Text);
            double resultMi = Math.Round(mileMi * 1609.34, 4);
            resultM.Text = resultMi.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verstVe = Convert.ToDouble(verst.Text);
            double resultVe = Math.Round(verstVe * 1066.8, 4);
            resultV.Text = resultVe.ToString();
        }
    }
}
