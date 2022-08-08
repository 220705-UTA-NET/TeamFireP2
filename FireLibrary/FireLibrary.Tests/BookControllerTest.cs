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
    public class BookControllerTest
    {
        [Fact]
        public void GetBook_Input_Result()
        {
            //the I'm might have to be I\u0027m to escape the apostrophe
            //given
            //arrange
            Book book = new Book("1785034677", "The Martian", "Andy Weir", "Dey Rey", "English", "I'm pretty much fucked.", "I'm pretty much fucked.", 400);//whatever book will be//needed to make a proper book object with title and all that
            BookResponse bookResponse = new BookResponse();
            bookResponse.Book = book;
            bookResponse.TotalCopies = 2;
            bookResponse.CopiesAvailable = 2;
            System.Console.WriteLine("help me");
            Mock<ILogger<BookController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();
            //still need to add IRepository something like mockRepo.Setup( x => x.GetBook(parameters)).Returns()
            var bookController = new BookController(mockRepo.Object, mockLogger.Object);//added the mock logger to satisfy constructor
            string json_should_be = JsonSerializer.Serialize(bookResponse);
            System.Console.WriteLine(json_should_be);
            json_should_be = @"{""Book"":{""Isbn"":""1785034677"",""Title"":""The Martian"",""Author"":""Andy Weir"",""Publisher"":""Dey Rey"",""Language"":""English"",""Synopsys"":""I'm pretty much fucked."",""Excerpt"":""I'm pretty much fucked."",""Pages"":400},""TotalCopies"":2,""CopiesAvailable"":2}";
            System.Console.WriteLine(json_should_be);
            //act
            //var result = await bookController.GetBookAsync("title", "author", "isbn");//once implemented should return a task and could use await
            var result = bookController.GetBookAsync("1785034677");
            //assert
            Assert.IsType<ContentResult>(result);//did it return action result
            Assert.IsType<ActionResult>(result);//did it return an action result//action result is abstract class -> that means it returns content?
            //Assert.Equal(json_should_be, result.Content);//it tells me content not defined in result, but I think it will return content
            //Assert.Equal(json_should_be, result.Value);//might not have value?//not sure how to test what returned content
        }
    }
}