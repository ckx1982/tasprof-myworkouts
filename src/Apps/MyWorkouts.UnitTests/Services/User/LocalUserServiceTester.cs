using System;
using Xunit;
using Tasprof.Apps.MyWorkouts.Services.User;

namespace Tasprof.Apps.MyWorkouts.UnitTests.Services.User
{
    public class LocalUserServiceTester
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var service = new LocalUserService();

            // Act 
            var userInfo =  service.AddUserAsync("testuser", "testpassword");

            // Assert
            Assert.Equal("testuser", userInfo.Result.Username);
        }
    }
}
