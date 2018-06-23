using System;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();
            if (App.AppCenterKey != null) Microsoft.AppCenter.Analytics.Analytics.TrackEvent("Visit AboutPage");

            var uiHandler = new Helpers.UIHandler();
            uiHandler.TitleBarVisiblity(false, Titlebar);
            uiHandler.TitleBarButton_TranparentBackground(true);

            Loaded += async (e, s) =>
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        String url = "https://raw.githubusercontent.com/yazdipour/WindOs/master/README.md";
                        MarkdownText.Text = await client.GetStringAsync(url);
                    }
                    catch { }
                }
            };

            SizeChanged += (sender, args) =>
            {
                MarkdownScrollViewer.Height =
                        ActualHeight -
                        LogoImage.ActualHeight -
                        (MarkdownScrollViewer.Margin.Top * 2);
                MarkdownText.Width = MarkdownScrollViewer.ActualWidth;
            };
        }

        private string _prefix = "https://github.com/yazdipour/WindOs/raw/master/";

        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();

        private async void Github_Click(object sender, RoutedEventArgs e)
            => await Windows.System.Launcher.LaunchUriAsync(new Uri("https://github.com/yazdipour/WindOs"));


        private async void Store_Click(object sender, RoutedEventArgs e)
            => await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store:REVIEW?PFN=5055881C-9F85-4877-AEA1-AF64140AD34D"));

        private async void MarkdownText_LinkClicked(object sender, Microsoft.Toolkit.Uwp.UI.Controls.LinkClickedEventArgs e)
            => await Windows.System.Launcher.LaunchUriAsync(new Uri(e.Link.Replace("./",_prefix)));
    }
}
