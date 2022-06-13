using System.Windows;
using System.Windows.Controls;

namespace Tv_App.Pages
{
    public partial class Setting_Page : UserControl
    {
        private MainWindow window;

        public Setting_Page()
        {
            InitializeComponent();
        }

        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }

        private void NetworkSetting_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Network);
        }

        private void Time_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Time);
        }

        private void Storage_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Storage);
        }

        private void About_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.About);
        }
    }
}