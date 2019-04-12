using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace MIC.Volo.TPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonDownload_Click(object sender, RoutedEventArgs e)
        {
            using(var client = new WebClient())
            {
                ButtonDownload.IsEnabled = false;
                TextOutput.Text = string.Empty;

                try
                {
                    var address = new Uri(TextURL.Text);

                    //string result = client.DownloadString(address);

                    Task<string> downloadTask = client.DownloadStringTaskAsync(address);
                
                    TextOutput.Text = "Downloading...";

                    string result = await downloadTask;

                    TextOutput.Text = new string(result.Take(200).ToArray());
                }
                catch (UriFormatException)
                {
                    TextOutput.Text = "Invalid URL";
                }
                catch (WebException exception)
                {
                    TextOutput.Text = exception.Message;
                }
                catch (NotSupportedException exception)
                {
                    TextOutput.Text = exception.Message;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    ButtonDownload.IsEnabled = true;
                }
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Text = "Calculating ...";

            int n = 100000000;

            double result = await CalculateAsync(n);

            TextOutput.Text = result.ToString();
        }

        private async Task<double> CalculateAsync(int n)
        {
            Func<double> func = () =>
            {
                var result = Enumerable.Range(0, n).Select(i => Math.Sin(i)).Sum();

                return result;
            };

            Task<double> task = Task.Factory.StartNew<double>(func);

            return await task;
        }
    }
}
