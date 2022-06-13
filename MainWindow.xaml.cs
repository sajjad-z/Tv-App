using System.Windows;
using System.Windows.Input;

namespace Tv_App
{
    public enum AppPages
    {
        About, Setting, Storage, Time, Network
    }

    public partial class MainWindow : Window
    {
        /// <summary>
        /// init all pages just one time 
        /// </summary>
        private Pages.Setting_Page settingPage = new Pages.Setting_Page();
        private Pages.About_Page aboutPage = new Pages.About_Page();
        private Pages.Storage_Page storagePage = new Pages.Storage_Page();
        private Pages.Time_Page timePage = new Pages.Time_Page();
        private Pages.Network_Page networkPage = new Pages.Network_Page();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ExecutePage(AppPages page)
        {
            backButton.Visibility = Visibility.Visible;

            switch (page)
            {
                case AppPages.About:
                    container.Content = aboutPage;
                    titleText.Text = "About Us";
                    break;
                case AppPages.Setting:
                    container.Content = settingPage;
                    titleText.Text = "Settings";
                    break;
                case AppPages.Storage:
                    container.Content = storagePage;
                    titleText.Text = "Storage";
                    break;
                case AppPages.Time:
                    container.Content = timePage;
                    titleText.Text = "Time Settings";
                    break;
                case AppPages.Network:
                    container.Content = networkPage;
                    titleText.Text = "Network Settings";
                    break;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            container.Content = settingPage;
            backButton.Visibility = Visibility.Collapsed;
            titleText.Text = "Settings";
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximize = false;
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;

                    IsMaximize = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximize = true;
                }
            }
        }
    }
}