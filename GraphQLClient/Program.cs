using GraphQL;
using GraphQL.Clint.Http;
using GraphQL.Client.Serializer.Newtonsoft;

var graphQLHttpCLientOptions = new GraphQLHttpCLientOptions
{
    EndPoint = new Url("");
}

var httpClient = new HttpClinet();
httpClient.DefaultRequestHeaders.Add("api-key", "");

var graphQLClint = new GraphQLHttpClient(graphQLHttpCLientOptions, new NewtonsoftJsonSerializer(), httpClient);