using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorials.MovieDB.MovieRow>;
using MyRow = MovieTutorials.MovieDB.MovieRow;

namespace MovieTutorials.MovieDB
{
    public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
    {
        public MovieRetrieveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}