using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorials.MovieDB.MovieCastRow>;
using MyRow = MovieTutorials.MovieDB.MovieCastRow;

namespace MovieTutorials.MovieDB
{
    public interface IMovieCastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastListHandler
    {
        public MovieCastListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}