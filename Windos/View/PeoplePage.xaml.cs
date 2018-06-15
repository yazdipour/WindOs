using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class PeoplePage : Page
    {
        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();

        public PeoplePage()
        {
            this.InitializeComponent();
        }
    }
}
