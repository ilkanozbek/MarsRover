using MarsRover.Application.Concrete;
using MarsRover.Application.Enumaration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void FirstRoverCheck()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), DirectionsEnum.N);
            firstRover.Process("LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverCheck()
        {
            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), DirectionsEnum.E);
            secondRover.Process("MMRMMRMRRM");
            Assert.AreEqual(secondRover.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectInput()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), DirectionsEnum.N);
            firstRover.Process("LMMTSARRD");
        }
    }
}
