using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCinema.Services;
using NetCoreCinema.Models;

/*This is project was made using the following sources

https://nbarbettini.gitbooks.io/little-asp-net-core-book/
https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2
https://docs.docker.com/
https://blog.codinghorror.com/understanding-model-view-controller/
https://www.digitalocean.com/community/tutorials/how-to-install-and-use-docker-on-ubuntu-18-04



*/

/* This the cinema controller 

It's a best practice to keep controllers as lightweight as possible. 
In this case, the controller will be responsible for getting the movie
items from the database, putting those items into a model the view can understand, 
and sending the view back to the user's browser.*/

namespace NetCoreCinema.Controllers
{

    public class CinemaController : Controller
    {
        /*Routes that are handled by controllers are called actions, 
        and are represented by methods in the controller class. For example, 
        the HomeController includes three action methods (Index, About, and Contact) 
        which are mapped by ASP.NET Core to these route URLs 
        
        Action methods can return views, JSON data, or HTTP status codes like 200 OK 
        and 404 Not Found. The IActionResult return type gives you the flexibility to 
        return any of these from the action.*/

        /*The first line of the class declares a private variable to hold a reference to the IMovieItemService. 
        This variable lets you use the service from the Index action method later (you'll see how in a minute).

        The public CinemaController(IMovieItemService movieItemService) line defines a constructor for the class. 
        The constructor is a special method that is called when you want to create a new instance of a class 
        (the CinemaController class, in this case). 
        By adding an IMovieItemService parameter to the constructor, you've declared that in order to create the 
        CinemaController, you'll need to provide an object that matches the IMovieItemService interface. */

        private readonly IMovieItemService _movieItemService;

        public CinemaController(IMovieItemService movieItemService)
        {
            _movieItemService = movieItemService;
        }


        public async Task<IActionResult> Index()
        {
            // Get Movie items from database

            var items = await _movieItemService.GetIncompleteItemsAsync();

            // Put items into a model

             var model = new MovieViewModel()
            {
                Items = items
            };

            // Render view using the model

            return View(model);
        }
    }
}
