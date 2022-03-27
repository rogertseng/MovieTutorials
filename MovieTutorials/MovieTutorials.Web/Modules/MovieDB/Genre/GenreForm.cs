using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieTutorials.MovieDB.Forms
{
    [FormScript("MovieDB.Genre")]
    [BasedOnRow(typeof(GenreRow), CheckNames = true)]
    public class GenreForm
    {
        public string Name { get; set; }
    }
}