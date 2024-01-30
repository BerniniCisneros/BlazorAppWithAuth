using Models;
using MongoDB.Bson;
using MongoDB.Driver;
using RestSharp;

const string connectionUri = "mongodb+srv://p00gz:Mistyn23.@emaily.r9zj8.mongodb.net/?retryWrites=true&w=majority";

var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Set the ServerApi field of the settings object to Stable API version 1
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var client = new MongoClient(settings);

Territory[] Territories = new Territory[]
        {
            new Territory
            {
                TerritoryId = 1,
                Name = "Uno",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 19,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 20,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 2,
                Name = "Dos",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 3,
                Name = "Tres",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 4,
                Name = "Cuatro",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 5,
                Name = "Cinco",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 6,
                Name = "Seis",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 7,
                Name = "Siete",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 8,
                Name = "Ocho",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 9,
                Name = "Nueve",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 19,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 10,
                Name = "Diez",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            },
            new Territory
            {
                TerritoryId = 11,
                Name = "Once",
                AssignedTo = "Tito Esquivel",
                Blocks = new Block[]
                {
                    new Block
                    {
                        Id = 1,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 2,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 3,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 4,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 5,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 6,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 7,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 8,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 9,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 10,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 11,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 12,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 13,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 14,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 15,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 16,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 17,
                        WorkedOn = null,
                        Worked = false,
                    },
                    new Block
                    {
                        Id = 18,
                        WorkedOn = null,
                        Worked = false,
                    }
                }
            }
        };

Captain[] captains = new Captain[]
{
    new Captain
    {
        CaptainId = 1,
        Name = "Tito Esquivel",
        Overseer = true,
        Mobile = "523328433860",
        AspNetUserName = "tito"
    },
    new Captain
    {
        CaptainId = 2,
        Name = "Norberto Valdez",
        Overseer = false,
        Mobile = "523313577912",
        AspNetUserName = "norberto"
    },
    new Captain
    {
        CaptainId = 3,
        Name = "Alejandro Blanco",
        Overseer = false,
        Mobile = "523310118415",
        AspNetUserName = "alejandro"
    },
    new Captain
    {
        CaptainId = 4,
        Name = "Bernini Cisneros",
        Overseer = false,
        Mobile = "523316035477",
        AspNetUserName = "bernini"
    },
    new Captain
    {
        CaptainId = 5,
        Name = "Samuel Silva",
        Overseer = false,
        Mobile = "523411395668",
        AspNetUserName = "samuel"
    },
    new Captain
    {
        CaptainId = 6,
        Name = "Ángel Rentería",
        Overseer = false,
        Mobile = "523322170858",
        AspNetUserName = "angel"
    },
    new Captain
    {
        CaptainId = 7,
        Name = "Luis Fernando Valdez",
        Overseer = false,
        Mobile = "523311577623",
        AspNetUserName = "luis"
    }
};

// Send a ping to confirm a successful connection
try
{
    //client.GetDatabase("emaily").CreateCollection("Users");
    //client.GetDatabase("emaily").CreateCollection("Territories");
    var territoriesCollection = client.GetDatabase("emaily").GetCollection<Territory>("Territories");
    territoriesCollection.DeleteMany(new BsonDocument());
    territoriesCollection.InsertMany(Territories);
    //var filter = Builders<Territory>.Filter
    //        .Eq(s => s., territoryId);
    //client.GetDatabase("emaily").CreateCollection("Capitanes");
    var captainsCollection = client.GetDatabase("emaily").GetCollection<Captain>("Capitanes");
    captainsCollection.DeleteMany(new BsonDocument());
    captainsCollection.InsertMany(captains);
    //var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    //Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
    
    /*string[] numbers = { "523323381846", "523312601177" };
    foreach (string mobile in numbers)
    {
        string instanceId = "instance75647"; // your instanceId
        string token = "gw0lz5kajyczjagb";         //instance Token
        //string mobile = "523316035477";
        string message = "Es temporada de dragones";
        var url = "https://api.ultramsg.com/" + instanceId + "/messages/chat";
        var client2 = new RestClient(url);
        var request = new RestRequest(url, Method.Post);
        request.AddHeader("content-type", "application/x-www-form-urlencoded");
        request.AddParameter("token", token);
        request.AddParameter("to", mobile);
        request.AddParameter("body", message);


        RestResponse response = await client2.ExecuteAsync(request);
        var output = response.Content;
        Console.WriteLine(output);
    }*/
    
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

