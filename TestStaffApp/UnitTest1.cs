using System;
using System.Threading.Tasks;
using Moq;
using Xunit;

using StaffApp.Controllers;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Abstractions;

namespace TestStaffApp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("5", "2");
            
        }

        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            //var controller = new HomeController();

            // Act
            //var result = controller.Index();

            // Assert
            //Assert.NotNull(result);


            /*
            // Arrange
            var mockRepo = new Mock<StaffAppContext>();
            mockRepo.Setup(repo => repo.ListAsync())
                .ReturnsAsync(GetTestSessions());
            var controller = new HomeController(mockRepo.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<StormSessionViewModel>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
            */
        }
    }


}
