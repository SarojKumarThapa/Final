using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    abstract class ShapesCreator
    {
       

        public abstract IShapes getShape(string ShapeType);
    }
}
