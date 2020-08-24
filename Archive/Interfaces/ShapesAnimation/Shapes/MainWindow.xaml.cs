using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Input;

namespace Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EllipseGeometry myEllipseGeometry;
        IEasingFunction myEasingFunction = new SlideEase();

        public MainWindow()
        {
            InitializeComponent();

            myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(200, 200);
            myEllipseGeometry.RadiusX = 20;
            myEllipseGeometry.RadiusY = 20;

            Path myPath = new Path();
            myPath.Fill = Brushes.SkyBlue;
            myPath.Data = myEllipseGeometry;

            myCanvas.Children.Add(myPath);
        }

        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(1));
            myPointAnimation.EasingFunction = myEasingFunction;

            myEllipseGeometry.BeginAnimation(EllipseGeometry.CenterProperty, myPointAnimation);
        }

        private void BounceEaseButton_Click(object sender, RoutedEventArgs e)
        {
            myEasingFunction = new BounceEase();
        }

        private void SlideEaseButton_Click(object sender, RoutedEventArgs e)
        {
            myEasingFunction = new SlideEase();
        }

        private void SlowFastEaseButton_Click(object sender, RoutedEventArgs e)
        {
            myEasingFunction = new SlowFastEase();
        }

        private void ElasticEaseButton_Click(object sender, RoutedEventArgs e)
        {
            myEasingFunction = new ElasticEase();
        }
    }
}
