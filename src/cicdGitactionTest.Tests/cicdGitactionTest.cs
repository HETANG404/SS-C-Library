using System;
using Xunit;
using cicdGitactionTest.Interfaces;
using cicdGitactionTest.Services;
using cicdGitactionTest.Models;

namespace cicdGitactionTest.Tests
{
    public class cicdGitactionTest
    {
        private readonly ICICDService _cicdService;

        public cicdGitactionTest()
        {
            _cicdService = new CICDService();
        }

        [Fact]
        public void GetCICDStatus_ShouldReturnSuccessMessage()
        {
            // Act
            string result = _cicdService.GetCICDStatus();

            // 输出结果，方便调试
            Console.WriteLine($"Test Result: {result}");

            // Assert
            Assert.Contains("!!!---CICD Successful---!!!", result);
            Assert.Contains(DateTime.Now.Year.ToString(), result); // 检查年份是否匹配
        }

        [Fact]
        public void CICDResponse_ShouldStoreMessageAndTimestamp()
        {
            // Arrange
            string testMessage = "Test Message";



            // Act
            var response = new CICDResponse(testMessage);


            // Assert
            Assert.Equal(testMessage, response.Message);
            Assert.True((DateTime.Now - response.Timestamp).TotalSeconds < 1); // 确保时间在合理范围
        }
    }
}
