﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Triangle : IShapes
    {
        public int x, y, width, height;

        public Triangle() : base()
        {
            width = 0;
            height = 0;
        }

        public Triangle(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void draw(Graphics g)
        {
            try
            {
                Point[] p = new Point[3];
                p[0].X = x;
                p[0].Y = y - (height / 2);

                p[1].X = x - (width / 2);
                p[1].Y = y + (height / 2);

                p[2].X = x + (width / 2);
                p[2].Y = y + (height / 2);
                Pen po = new Pen(Color.Black, 2);
                g.DrawPolygon(po, p);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void set(Color c, params int[] list)
        {
            this.x = list[0]; this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
}
