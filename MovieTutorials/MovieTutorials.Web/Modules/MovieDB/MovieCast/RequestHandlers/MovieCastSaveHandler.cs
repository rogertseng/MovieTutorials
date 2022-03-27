using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorials.MovieDB.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorials.MovieDB.MovieCastRow;

namespace MovieTutorials.MovieDB
{
    public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
    {
        public MovieCastSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}