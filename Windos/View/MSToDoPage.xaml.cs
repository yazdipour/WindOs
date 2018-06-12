using System.Collections.Generic;
using Windos.Model;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class MSToDoPage : Page
    {
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
        public MSToDoPage()
        {
            this.InitializeComponent();
            var h = new Helpers.UIHandler();
            h.TitleBarVisiblity(false, Titlebar);
            h.TitleBarButton_TranparentBackground(false);
        }


        private void GoHome_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
