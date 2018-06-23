using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class TerminalPage : Page
    {
        string[] Tabs = { "Terminal#1", "Terminal#2" };

        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();

        public TerminalPage()
        {
            this.InitializeComponent();
            var uiHandler = new Helpers.UIHandler();
            uiHandler.TitleBarVisiblity(false, Titlebar);
            uiHandler.TitleBarButton_TranparentBackground(true);
            TabLV.ItemsSource = Tabs;
            TabLV.SelectedIndex = 0;
            Console.Text = "Windows PowerShell \nCopyright(C) Microsoft Corporation. All rights reserved. \n\nPS C:\\Users\\Shahriar >";
        }
    }
}
