using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Abstract
{
    public interface IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    }
}
