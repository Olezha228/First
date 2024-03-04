using First.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FirstTests
{
    public class DataControllerTests
    {
        private Mock<IUrlHelper> _mockUrlHelper;
        private DataController _controller;

        public DataControllerTests()
        {
            _mockUrlHelper = new Mock<IUrlHelper>();
            _controller = new DataController();
        }

        [Fact]
        public void Get_ReturnsOkResult_WithData()
        {
            // Arrange
            var expectedData = new { Name = "John", Age = 30 };

            // Act
            var result = _controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);

            Assert.Equal("{ Name = John, Age = 30 }", okResult.Value.ToString());
        }
    }
}
