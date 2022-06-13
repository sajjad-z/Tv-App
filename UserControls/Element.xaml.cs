using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.IconPacks;

namespace Tv_App.UserControls
{
    public partial class Element : UserControl
    {
        public static readonly RoutedEvent ElementClickEvent =
            EventManager.RegisterRoutedEvent("ElementClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Element));

        public event RoutedEventHandler ElementClick
        {
            add { AddHandler(ElementClickEvent, value); }
            remove { RemoveHandler(ElementClickEvent, value); }
        }

        void Button_Click(object sender, RoutedEventArgs e) => RaiseEvent(new RoutedEventArgs(ElementClickEvent));


        public Element()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Element));


        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(Element));


        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(Element));

    }
}