using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

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

                   
                    SaveFileDialog save = new SaveFileDialog();
                    save.ShowDialog();

                    client.DownloadFile(address, save.FileName);
                    
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
    }
}
