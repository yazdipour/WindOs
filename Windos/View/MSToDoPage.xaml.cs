using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Windos.View
{
    public sealed partial class MSToDoPage : Page
    {
        List<string> NavLinks=new List<string>() { "Navigation" , "Navigation" , "Navigation" };
        public MSToDoPage()
        {
            this.InitializeComponent();
        }
    }
}
