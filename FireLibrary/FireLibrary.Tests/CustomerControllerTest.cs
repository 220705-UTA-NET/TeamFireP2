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

    public class CustomerControllerTest
    {
        [Fact]
        public async Task GetCustomer_Input_Result()
        {
            Customer customer = new Customer(12345, "username1", true, 0, 0);
            
            System.Console.WriteLine("customer test ");
            Mock<ILogger<CustomerController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();
            var customerController = new CustomerController(mockRepo.Object, mockLogger.Object);

            string json_should_be = JsonSerializer.Serialize(customer);
            System.Console.WriteLine(json_should_be);
            json_should_be = @"{""CustomerId"":12345,""Username"":""username1"",""CanBorrow"":true,""Fines"":0,""BookCount"":0}";
            System.Console.WriteLine(json_should_be);

            var result = await customerController.GetCustomerAsync(12345, "username1");

            //Assert.IsType<ContentResult>(result);
            //Assert.IsType<ActionResult>(result);

            var resultContent = result.Result as ContentResult;
            Assert.Equal(json_should_be, resultContent.Content);
        }
    }
}