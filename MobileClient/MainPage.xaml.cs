namespace MobileClient;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        _ = InitializeWebView();
    }

    private async Task InitializeWebView()
    {
        // Initialize WebView with the same URL as DesktopClient
        webView.Source = "http://j919433u.beget.tech/MAMASD13/public/";
    }
}

