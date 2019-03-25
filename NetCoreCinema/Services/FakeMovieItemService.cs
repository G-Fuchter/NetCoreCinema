using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreCinema.Models;

namespace NetCoreCinema.Services
{

    /*This is the actual service class:
    This FakeMovieItemService implements the IMovieItemService interface but always returns the same array of 4 MovieItem*/
    public class FakeMovieItemService : IMovieItemService
    {
        public Task<MovieItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new MovieItem
            {
                Title = "The Perfect Interview: The Movie",
                ScreenAt = DateTime.Now.AddDays(1),
                HasSubtitles = true,
                Price = 14.99f,
                Discount = 50
            };

            var item2 = new MovieItem
            {
                Title = "Cool Awesome Apps III",
                ScreenAt = DateTime.Now.AddDays(3),
                HasSubtitles = false,
                Price = 29.99f
            };

            var item3 = new MovieItem
            {
                Title = "Hey Look At Me! I Am A Movie!",
                ScreenAt = DateTime.Now.AddDays(6),
                HasSubtitles = true,
                Price = 5.99f
            };

            var item4 = new MovieItem
            {
                Title = "Cool Awesome Apps I",
                ScreenAt = DateTime.Now.AddHours(2),
                HasSubtitles = false,
                Price = 9.99f,
                Discount = 90
            };

            return Task.FromResult(new[] { item1, item2, item3, item4 });
        }
    }
}
