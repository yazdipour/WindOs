using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class GroovePage : Page
    {
        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();
        public GroovePage()
        {
            this.InitializeComponent();
        }
    }
}
