namespace FireLibrary.Tests;
using Xunit;
using Xunit.Sdk;
using Moq;
using Microsoft.Extensions.Logging;
using FireLibrary.API.Controllers;
using FireLibrary.Model;
using FireLibrary.Data;
using Microsoft.AspNetCore.Mvc;//needed to get type ContentResult

public class BookControllerTest
{
    [Fact]
    public void GetBook_Input_Result()
    {
        //given
        //arrange
        Book book = new Book();//whatever book will be//needed to make a proper book object with title and all that
        Mock<ILogger<BookController>> mockLogger = new();
        Mock<IRepository> mockRepo = new();
        var bookController = new BookController(mockRepo.Object, mockLogger.Object);//added the mock logger to satisfy constructor
        string json_should_be = @"{""author"":""author""}";
        //act
        //var result = await bookController.GetBookAsync("title", "author", "isbn");//once implemented should return a task and could use await
        var result = bookController.GetBookAsync("title", "author", "isbn");
        Assert.IsType<ContentResult>(result);//did it return action result
        Assert.IsType<ActionResult>(result);//did it return an action result//action result is abstract class -> that means it returns content?
        //Assert.Equal(json_should_be, result.Content);//it tells me content not defined in result | but I think it will return content
        Assert.Equal(json_should_be, result.Value);//might not have value?//not sure how to test what returned content
    }
}
