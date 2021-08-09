using MarsRover.Application.Abstract;
using MarsRover.Application.Enumaration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Concrete
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public DirectionsEnum RoverDirection { get; set; }
        public Rover(IPlateau roverPlateau, IPosition roverPosition, DirectionsEnum roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < DirectionsEnum.N ? DirectionsEnum.W : RoverDirection - 1;
        }

        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > DirectionsEnum.W ? DirectionsEnum.N : RoverDirection + 1;
        }
        private void Move()
        {

            switch (RoverDirection)
            {
                case DirectionsEnum.N:
                    RoverPosition.YCoordinate++;
                    break;
                case DirectionsEnum.E:
                    RoverPosition.XCoordinate++;
                    break;
                case DirectionsEnum.S:
                    RoverPosition.YCoordinate--;
                    break;
                case DirectionsEnum.W:
                    RoverPosition.XCoordinate--;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.XCoordinate, RoverPosition.YCoordinate, RoverDirection);
        }
    }
}
