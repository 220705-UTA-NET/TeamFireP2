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
            CustomerResponse customerResponse = new CustomerResponse();
            customerResponse.Customer = customer;
            customerResponse.OutstandingBooks = 0;
            customerResponse.Fines = 0;
            System.Console.WriteLine("customer test ");
            Mock<ILogger<CustomerController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();
            var customerController = new CustomerController(mockRepo.Object, mockLogger.Object);

            string json_should_be = JsonSerializer.Serialize(customerResponse);
            System.Console.WriteLine(json_should_be);
            json_should_be = @"{""Customer"":{""CustomerID"":12345,""Username"":""username1"",""CanBorrow"":true,""BookCount"":0},""OutstandingBooks"":0,""Fines"":0}";
            System.Console.WriteLine(json_should_be);

            var result = customerController.GetCustomerAsync(12345, "username1");

            Assert.IsType<ContentResult>(result);//did it return action result
            Assert.IsType<ActionResult>(result);
        }
    }
}