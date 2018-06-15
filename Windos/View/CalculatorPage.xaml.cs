using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class CalculatorPage : Page
    {
        public CalculatorPage()
        {
            this.InitializeComponent();
            var uiHandler = new Helpers.UIHandler();
            uiHandler.TitleBarVisiblity(false, Titlebar);
            uiHandler.TitleBarButton_TranparentBackground(false);

            TreeViewNode calculatorFolder = new TreeViewNode() { Content = "Calculator", IsExpanded = true };

            calculatorFolder.Children.Add(new TreeViewNode() { Content= "Standard" });
            calculatorFolder.Children.Add(new TreeViewNode() { Content = "Scientific" });
            calculatorFolder.Children.Add(new TreeViewNode() { Content = "Programmer" });
            calculatorFolder.Children.Add(new TreeViewNode() { Content = "Date Calculation" });

            TreeViewNode converterFolder = new TreeViewNode() { Content = "Converter" };
            converterFolder.Children.Add(new TreeViewNode() { Content = "1" });
            converterFolder.Children.Add(new TreeViewNode() { Content = "2" });
            converterFolder.Children.Add(new TreeViewNode() { Content = "3" });

            TreeViewNode settings = new TreeViewNode() { Content = "Settings" };

            tree.RootNodes.Add(calculatorFolder);
            tree.RootNodes.Add(converterFolder);
            tree.RootNodes.Add(settings);
        }

        private void GoHome_Click(object sender, RoutedEventArgs e) => Frame.GoBack();
    }
}
