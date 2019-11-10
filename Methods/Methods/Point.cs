using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        internal void Move()
        {
            throw new NotImplementedException();
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            Move(newLocation.X, newLocation.Y);
        }
    }
}