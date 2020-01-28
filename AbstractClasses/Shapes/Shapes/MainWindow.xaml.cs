using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;

            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);
            myCanvas.Children.Add(myRect);

            Diamond myDiamond = new Diamond();
            myDiamond.Fill = Brushes.SkyBlue;
            myDiamond.Stroke = Brushes.Black;
            myDiamond.StrokeThickness = 2;

            Canvas.SetTop(myDiamond, 200);
            Canvas.SetLeft(myDiamond, 200);
            myCanvas.Children.Add(myDiamond);
        }
    }
}
