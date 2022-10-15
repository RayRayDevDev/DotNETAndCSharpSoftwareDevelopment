using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace ModuleTwoSDLCAssignment
{
    public partial class UserControl1 : Window
    {
        public static IEnumerable<string>? matches;
        private static string first;
        private static string last;

        public static void getVar(string oneFirst, string oneLast)
        {
            first = oneFirst;
            last = oneLast;
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void clickMeButtonMost(object sender, RoutedEventArgs e)
        {
            maxCount.Content = first;

        }

        private void clickMeButtonLeast(object sender, RoutedEventArgs e)
        {
            minCount.Content = last;
        }
    }


}
