using System;
using System.Windows.Media.Animation;

namespace Shapes
{
    class SquareEase : IEasingFunction
    {
        public double Ease(double x)
        {
            return x*x;
        }
    }
}
