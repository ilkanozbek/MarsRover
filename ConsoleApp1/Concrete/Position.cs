using MarsRover.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Concrete
{
    public class Position : IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
