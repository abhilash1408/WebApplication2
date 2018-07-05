using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication2.Controllers;
using WebApplication2.Models;
using WebApplication2.Services;
using Xunit;

namespace XUnitTestProject1
{
    public class ClansControllerTest
    {
        protected ClansController ControllerUnderTest { get; }
        protected Mock<IClanService<Clan>> ClanServiceMock { get; }
        public ClansControllerTest()
        {
            ClanServiceMock = new Mock<IClanService<Clan>>(); // IClanService mock
            ControllerUnderTest = new ClansController(ClanServiceMock.Object);
        }

        public class ReadAllAsync : ClansControllerTest
        {
            [Fact]
            public async void Should_return_OkObjectResult_with_clans()
            {
                 //Arrange
                var expectedClans = new Clan[]
                {
                   new Clan { Name = "Test clan 1" },
                    new Clan { Name = "Test clan 2" },
                    new Clan { Name = "Test clan 3" }
                };
                ClanServiceMock
                    .Setup(x => x.ReadAllAsync())
                    .ReturnsAsync(expectedClans); // Mocked the ReadAllAsync() method

                // Act
                var result = await ControllerUnderTest.ReadAllAsync();

                // Assert
                var okResult = Assert.IsType<OkObjectResult>(result);
                Assert.Same(expectedClans, okResult.Value);
            }
        }
    }
}
