using Xunit;
using Xunit.Sdk;
using Moq;
using Microsoft.Extensions.Logging;
using FireLibrary.API.Controllers;
using FireLibrary.Model;
using FireLibrary.Data;
using Microsoft.AspNetCore.Mvc;//needed to get type ContentResult
using System.Text.Json;

namespace FireLibrary.Tests
{
    public class AuthorControllerTest
    {
        [Fact]
        public async Task GetCustomer_Input_Result()
        {
            Author author = new Author(12345, "authorname1");

            Console.WriteLine("author test");
            Mock<ILogger<AuthorController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();
            var authorController = new AuthorController(mockRepo.Object, mockLogger.Object);

            string json_should_be = JsonSerializer.Serialize(author);
            System.Console.WriteLine(json_should_be);
            json_should_be = @"{""AuthorId"":12345,""Name"":""authorname1""}";
            System.Console.WriteLine(json_should_be);

            var result = await authorController.GetAuthorAsyncById(12345);

            //Assert.IsType<ContentResult>(result);
            //Assert.IsType<ActionResult>(result);

            var resultContent = result.Result as ContentResult;
            Assert.Equal(json_should_be, resultContent.Content);
        }
    }
}

