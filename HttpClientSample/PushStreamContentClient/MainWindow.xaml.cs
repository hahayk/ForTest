using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace PushStreamContentClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient client;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SubscribeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.client == null)
            {
                this.client = new HttpClient();
                var stream = await client.GetStreamAsync("http://localhost:1870/api/Price/Subscribe");

                try
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (true)
                        {
                            var line = await reader.ReadLineAsync() + Environment.NewLine;

                            this.OutputField.Text += line;
                            this.OutputField.ScrollToEnd();

                        }
                    }
                }
                catch (Exception)
                {
                    this.OutputField.Text += "Stream ended";
                }
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            if (this.client != null)
                this.client.Dispose();
        }
    }
}