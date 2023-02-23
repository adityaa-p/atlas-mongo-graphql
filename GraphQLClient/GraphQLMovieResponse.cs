public class GraphQLMovieResponse {
    
    public Movie Movie { get; set; }
}

public class Movie {

    public string Title { get; set; } 

    public string Plot { get; set; }

    public List<string> Cast { get; set; }

    public int Runtime { get; set; }
}