using System;
using System.Windows.Media.Animation;

namespace Shapes
{
    class SlideEase : IEasingFunction
    {
        public double Ease(double x)
        {
            return x*x*x - 3*x*x + 3*x;
        }
    }
}
