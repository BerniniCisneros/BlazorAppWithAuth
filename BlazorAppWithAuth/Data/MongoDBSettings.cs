namespace BlazorAppWithAuth.Data
{
    public class MongoDBSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Pwd { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CategoriesCollection { get; set; } = null!;
        public string MongoDBConnectionString => $"{ConnectionURI}";
    }
}
