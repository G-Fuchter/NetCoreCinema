using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreCinema.Models;

/*You've created a model, a view, and a controller.
 Before you use the model and view in the controller, 
 you also need to write code that will get the user's movie items from a database.

You could write this database code directly in the controller, 
but it's a better practice to keep your code separate. 
Why? In a big, real-world application, you'll have to juggle many concerns 

The C# language includes the concept of interfaces, where the definition of an object's methods 
and properties is separate from the class that actually contains the code for those methods and properties. 
Interfaces make it easy to keep your classes decoupled and easy to test. 
You'll use an interface to represent the service that can interact with Movie items in the database.*/

namespace NetCoreCinema.Services
{
    public interface IMovieItemService
    {
        Task<MovieItem[]> GetIncompleteItemsAsync();
    }
}
