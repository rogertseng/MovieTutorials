namespace MovieTutorials.MovieDB {
    export interface MovieListRequest extends Serenity.ListRequest {
        Genres?: number[];
    }
}
