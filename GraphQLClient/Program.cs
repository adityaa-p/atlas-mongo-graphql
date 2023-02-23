using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

var graphQLHttpClientOptions = new GraphQLHttpClientOptions
{
    EndPoint = new Uri("https://ap-south-1.aws.realm.mongodb.com/api/client/v2.0/app/application-0-nqblv/graphql")
};

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("apikey", "wVrBNnlVbU3x2VMKWqaV7g2ulqGjO0cE2UKpP1mP2wbXWAs9FJPylFpYtZGrsRaK");

var graphQLClient = new GraphQLHttpClient(graphQLHttpClientOptions, new NewtonsoftJsonSerializer(), httpClient);

var movieRequest = new GraphQLRequest {
    Query = @"
        {
            movie {
                title,
                plot,
                cast,
                runtime
            }
        }
    "
};

var graphQLResponse = await graphQLClient.SendQueryAsync<GraphQLMovieResponse>(movieRequest);

Console.WriteLine($"{graphQLResponse.Data.Movie.Title} {graphQLResponse.Data.Movie.Plot}");
foreach (var item in graphQLResponse.Data.Movie.Cast)
{
    Console.WriteLine(item);
}
Console.WriteLine(graphQLResponse.Data.Movie.Runtime);