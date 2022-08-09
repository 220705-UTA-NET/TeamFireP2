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
        public void GetCustomer_Input_Result()
        {
            Customer customer = new Customer(12345, "username1", true, 0);
            System.Console.WriteLine("help me");
            Mock<ILogger<CustomerController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();
            var customerController = new CustomerController(mockRepo.Object, mockLogger.Object);
            var result = customerController.GetCustomerAsync(12345, "username1");

            Assert.IsType<ContentResult>(result);//did it return action result
            Assert.IsType<ActionResult>(result);
        }
    }
}

