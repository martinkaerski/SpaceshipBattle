﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SpaceshipBattle.Contracts;
using SpaceshipBattle.Tests.SpaceshipTests.Mocks;
using System;


namespace SpaceshipBattle.Tests.SpaceshipTests
{
    [TestClass]
    public class TakeDamageToPlayer_Should
    {
        [TestMethod]
        public void ThrowNullReferenceException_WhenNullSpaceshipIsGiven()
        {
            //Arrange
            var engineMock = new Mock<ISpaceshipEngine>();
            var armourMock = new Mock<IArmour>();
            var weaponMock = new Mock<IWeapon>();

            var spaceship = new SpaceshipMock(engineMock.Object, armourMock.Object, weaponMock.Object, "model");

            Assert.ThrowsException<NullReferenceException>(() => spaceship.TakeDamageToPlayer(null, 10));
        }
               
    }
}
