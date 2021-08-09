using MarsRover.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Concrete
{
    public class Plateau : IPlateau
    {
        public Position Position { get; private set; }

        public Plateau(Position position)
        {
            Position = position;
        }
    }
}
