using System.Collections.Generic;
using Windos.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class PeoplePage : Page
    {
        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();

        NavButton[] navButtons = {
            new NavButton()
            {
                Title="Shahriar Yazdipour",
                Icon="ms-appx:///Assets/Imgs/avatar/shahriar.jpg"
            },
            new NavButton()
            {
                Title="Satya Nadella",
                Icon="ms-appx:///Assets/Imgs/avatar/satya.jpg"
            },
            new NavButton()
            {
                Title="Nikola Metulev",
                Icon="ms-appx:///Assets/Imgs/avatar/nikola.jpg"
            },
            new NavButton()
            {
                Title="Shen Chauhan",
                Icon="ms-appx:///Assets/Imgs/avatar/shen.jpg"
            }
        };
        public PeoplePage()
        {
            this.InitializeComponent();
            var uiHandler = new Helpers.UIHandler();
            uiHandler.TitleBarVisiblity(false, Titlebar);
            uiHandler.TitleBarButton_TranparentBackground(false);
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
