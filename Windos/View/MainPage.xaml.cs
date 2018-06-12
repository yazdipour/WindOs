using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Windos.View
{
    public sealed partial class MainPage : Page
    {
        List<NavButton> navButtons = new List<NavButton>()
        {
            new NavButton()
            {
                Title="File Explorer",
                PageType=typeof(FileExplorerPage),
                Bg="#746BC4",
                Icon=""
            },
            new NavButton()
            {
                Title="Calculator",
                PageType=typeof(CacheMode),
                Bg="#746BC4",
                Icon=""
            },
            new NavButton()
            {
                Title="Spotify",
                PageType=typeof(GroovePage),
                Bg="#ff0000",
                Icon=""
            },
            new NavButton()
            {
                Title="People",
                PageType=typeof(PeoplePage),
                Bg="#746BC4",
                Icon=""
            },
            new NavButton()
            {
                Title="Skype",
                PageType=typeof(SkypePage),
                Bg="#ff0000",
                Icon=""
            },
            new NavButton()
            {
                Title="Microsoft ToDo",
                PageType=typeof(MSToDoPage),
                Bg="#ff0000",
                Icon=""
            }
        };
        public MainPage()
        {
            this.InitializeComponent();
            var h = new Helpers.UIHandler();
            h.TitleBarVisiblity(false, null);
            h.TitleBarButton_TranparentBackground(false);
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var btn = e.ClickedItem as NavButton;
            Frame.Navigate(btn.PageType);
        }
    }

    internal class NavButton
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Bg { get; set; }
        public Type PageType;
    }
}
