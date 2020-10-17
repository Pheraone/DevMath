using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            t = DevMath.Clamp(t, 0, 1);
            
            //eerst clampen dan lerpen  
            return a + (b - a) * t;
            //andere optie:
            //return(a *(1 - t) + b * t);
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            //check this?
            return ((startVelocity * time) + (0.5f * acceleration * (time * time)));
        }

        public static float Clamp(float value, float min, float max)
        {
            if(value <= max && value >= min)
            {
                return value;
            }
            else if(value > max)
            {
                //can I return max?
                value = max;
                return value;
            }
            else if(value < min)
            {
                //Or can I return min?
                value = min;
                return value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static float RadToDeg(float angle)
        {
            return (angle * ((float)Math.PI / 180));
        }

        public static float DegToRad(float angle)
        {
            return (angle * (180 / (float)Math.PI));
        }
    }
}
