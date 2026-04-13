using System;
using System.Collections.Generic;
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

namespace DesktopClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = InitializeWebView();
        }
        private async Task InitializeWebView()
        {
            // Инициализирует среду выполнения Chromium
            await WebView.EnsureCoreWebView2Async(null);

            // Загружаем сайт
            WebView.CoreWebView2.Navigate("http://j919433u.beget.tech/MAMASD13/public/");
        }
    }
}
