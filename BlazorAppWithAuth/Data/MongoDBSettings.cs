namespace BlazorAppWithAuth.Data
{
    public class MongoDBSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Pwd { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CategoriesCollection { get; set; } = null!;
        public string MongoDBConnectionString => $"mongodb+srv://p00gz:Mistyn23.@emaily.r9zj8.mongodb.net/?retryWrites=true&w=majority";
    }
}
