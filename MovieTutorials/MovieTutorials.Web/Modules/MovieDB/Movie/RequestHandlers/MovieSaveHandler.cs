using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorials.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorials.MovieDB.MovieRow;

namespace MovieTutorials.MovieDB
{
    public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
    {
        public MovieSaveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}