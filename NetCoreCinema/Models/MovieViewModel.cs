using System;

namespace NetCoreCinema.Models
{

    /*There are two separate model classes that need to be created: 
    a model that represents a to-do item stored in the database (sometimes called an entity), 
    and the model that will be combined with a view (the MV in MVC) and sent back to the user's browser. 
    Because both of them can be referred to as "models", I'll refer to the latter as a view model. */
    public class MovieViewModel
    {
        public MovieItem[] Items {get; set;}
    }
}
