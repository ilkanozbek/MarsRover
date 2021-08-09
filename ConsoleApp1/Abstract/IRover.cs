using MarsRover.Application.Enumaration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Abstract
{
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        DirectionsEnum RoverDirection { get; set; }
        void Process(string commands);
        string ToString();
    }
}
