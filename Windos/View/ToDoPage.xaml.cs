using System.Collections.Generic;
using Windos.Model;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class ToDoPage : Page
    {
        private void GoHome_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) => Frame.GoBack();

        List<NavButton> navButtons = new List<NavButton>()
        {
            new NavButton()
            {
                Title="Shop",
                Icon="✏"
            },
            new NavButton()
            {
                Title="ToDo",
                Icon="☎"
            },
            new NavButton()
            {
                Title="List",
                Icon="☺"
            },
            new NavButton()
            {
                Title="List 2",
                Icon="✔"
            }
        };
        public ToDoPage()
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
                    MenuAppBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
                else
                {
                    splitView.IsPaneOpen = true;
                    MenuAppBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }

            };
            MenuAppBar.Click += (s, e) => splitView.IsPaneOpen = !splitView.IsPaneOpen;
            CloseDetailsBtn.Click += (s, e) => insideSplitView.IsPaneOpen = false;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            insideSplitView.IsPaneOpen = !insideSplitView.IsPaneOpen;
        }
    }
}
