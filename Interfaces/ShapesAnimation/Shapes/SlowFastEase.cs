using System;
using System.Windows.Media.Animation;

namespace Shapes
{
    class SlowFastEase : IEasingFunction
    {
        public double Ease(double x)
        {
            if (x < .75)
            {
                return x / 5;
            }
            else
            {
                return 3.4 * x - 2.4;
            }
        }
    }
}
