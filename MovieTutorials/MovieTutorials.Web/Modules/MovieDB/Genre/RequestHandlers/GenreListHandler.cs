using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorials.MovieDB.GenreRow>;
using MyRow = MovieTutorials.MovieDB.GenreRow;

namespace MovieTutorials.MovieDB
{
    public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
    {
        public GenreListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}