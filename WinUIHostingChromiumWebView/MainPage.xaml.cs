using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace WinUIHostingChromiumWebView
{
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      webView2.UriSource = new Uri("https://localhost:44305/");
    }

    private async void ButtonSetFirstName_Click(object sender, RoutedEventArgs e)
    {
      await webView2.ExecuteScriptAsync($"interopFunctions.setFirstName('{txtFirstName.Text}');");
    }
  }
}
