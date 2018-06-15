using System.Collections.Generic;
using Windos.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class SkypePage : Page
    {
        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();

        List<NavButton> navButtons = new List<NavButton>()
        {
            new NavButton()
            {
                Title="Shahriar Yazdipour",
                Icon="ms-appx:///Assets/Imgs/ghost.jpg"
            },
            new NavButton()
            {
                Title="Satya Nadella",
                Icon="ms-appx:///Assets/Imgs/ghost.jpg"
            },
            new NavButton()
            {
                Title="Satya Nadella",
                Icon="ms-appx:///Assets/Imgs/ghost.jpg"
            },
            new NavButton()
            {
                Title="David",
                Icon="ms-appx:///Assets/Imgs/ghost.jpg"
            }
        };
        public SkypePage()
        {
            this.InitializeComponent();
            var uiHandler = new Helpers.UIHandler();
            uiHandler.TitleBarVisiblity(false, Titlebar);
            uiHandler.TitleBarButton_TranparentBackground(true);
            SizeChanged += (s, e) =>
            {
                if (e.NewSize.Width < 720)
                {
                    splitView.IsPaneOpen = false;
                    //MenuAppBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
                else
                {
                    splitView.IsPaneOpen = true;
                    //MenuAppBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }

            };
        }
    }
}
