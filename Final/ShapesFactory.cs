﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class ShapesFactory : ShapesCreator
    {
        public override IShapes getShape(string ShapeType)
        {
            ShapeType = ShapeType.ToLower().Trim();
            if (ShapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (ShapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }

            else if (ShapeType.Equals("triangle"))
            {
                return new Triangle();
            }

            else
            {
                //throw an appropriate exception.
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + ShapeType + " does not exist");
                throw argEx;
            }
        }
    }
}
