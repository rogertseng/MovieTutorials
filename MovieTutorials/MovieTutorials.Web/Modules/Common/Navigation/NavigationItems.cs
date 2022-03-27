﻿using Serenity.Navigation;
using MovieDB = MovieTutorials.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
[assembly: NavigationMenu(2000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MovieDB.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(2200, "Movie Database/Genres", typeof(MovieDB.GenreController), icon: "fa-thumb-tack")]
[assembly: NavigationLink(2300, "Movie Database/Person", typeof(MovieDB.PersonController), icon: "fa-person")]
