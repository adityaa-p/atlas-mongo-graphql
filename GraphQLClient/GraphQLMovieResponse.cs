public class GraphQLMovieResponse {
    
    public Movie movie { get; set; }
}

public class Movie {

    public string Title { get; set; } 

    public string Plot { get; set; }
}