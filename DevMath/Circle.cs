using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
           Vector2 aap = circle.Position - this.Position;
            float i = aap.Magnitude;
            i = i - this.Radius - circle.Radius;
            return (i <= 0);
            //ask this!!
            //float i;
            //if(  i <= 0 )
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
