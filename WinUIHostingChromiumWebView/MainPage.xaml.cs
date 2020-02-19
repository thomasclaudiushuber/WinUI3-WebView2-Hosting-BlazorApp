using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System;

namespace WinUIHostingChromiumWebView
{
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      webView2.UriSource = new Uri("https://localhost:44305/");
      webView2.WebMessageReceived += WebView2_WebMessageReceived;
    }

    private void WebView2_WebMessageReceived(WebView2 sender, WebView2WebMessageReceivedEventArgs args)
    {
      var jsonString = args.WebMessageAsString;
      var message = JsonConvert.DeserializeObject<WebMessage>(jsonString);
      if (message.MessageType == "firstName")
      {
        txtFirstName.Text = message.Value;
      }
    }

    private async void ButtonSetFirstName_Click(object sender, RoutedEventArgs e)
    {
      await webView2.ExecuteScriptAsync($"interopFunctions.setFirstName('{txtFirstName.Text}');");
    }
  }
}
