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

namespace Mic.Volo.PrimeNumber
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

        private async void CountBtn_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(textInput.Text);
            textOutput.Text = (await PrimeNumAsync(n)).ToString();
        }
        public async Task<int> PrimeNumAsync(int n)
        {
            Func<int> myFunc = () =>
              {
                  int temp = 1;
                  int count = 1;

                  while (count < n)
                  {
                      bool b = true;
                      temp++;

                      for (int i = 2; i < temp / 2; i++)
                      {
                          if (temp % i == 0)
                          {
                              b = false;
                              break;
                          }
                      }
                      if (b)
                      {
                          count++;
                      }
                  }

                  return temp;
              };
            Task<int> myTask = Task.Factory.StartNew<int>(myFunc);
            return await myTask;
        }
    }
}
