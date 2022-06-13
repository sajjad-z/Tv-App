using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tv_App.UserControls
{
    public partial class StorageDesc : UserControl
    {
        public StorageDesc()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(StorageDesc));


        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(StorageDesc));

    }
}