using LibraryChallenge.Communication.Request;
using LibraryChallenge.Communication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace LibraryChallenge.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book { author = "Bidu", gender = "Filosofia", price = 499.99, stock = 10, title = "Bidu pensamentos"  },
            new Book { author = "Chica", gender = "Aventura", price = 199.00, stock = 57, title = "Chica aventuras"  },
            new Book { author = "Jack", gender = "Comédia", price = 99.99, stock = 1000, title = "jack comédias"  },
            new Book { author = "Duda", gender = "Romance", price = 399.99, stock = 26, title = "Duda romances"  },
            
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterBookJSON request)
    {
        var data = request;

        var book = new Book() { 
            title = data.title,
            author = data.author ?? "",
            gender = data.gender ?? "",
            price = data.price,
            stock = data.stock
        };

        return Ok(book);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id,[FromBody] RequestUpdateBookJSON request)
    {
        var data = request;

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
