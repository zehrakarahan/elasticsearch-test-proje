using Elastictest.EntityFramework;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elastictest
{
    class Program
    {

        public static void Main(string[] args)
        {


            ConnectionSettings connSettings =
new ConnectionSettings(new Uri("http://localhost:9200/"))
           .DefaultIndex("customerlocation")
           //Optionally override the default index for specific types
           .DefaultMappingFor<City>(m => m
           .IndexName("loglama"));




        ElasticClient elasticClient = new ElasticClient(connSettings);

        List<City> city = new List<City>();
            city.Add(new City{Name = "delhi1",State = "delhi1",Country = "India1",Population = "9.879 million1" });
            city.Add(new City{ Name = "delhi3", State = "delhi3", Country = "India3", Population = "9.879 million3" });
            city.Add(new City {  Name = "delhi4", State = "delhi4", Country = "India4", Population = "9.879 million4" });
            city.Add(new City{  Name = "delhi5", State = "delhi5", Country = "India5", Population = "9.879 million5" });
            city.Add(new City { Name = "delhi6", State = "delhi6", Country = "India6", Population = "9.879 million6" });
 




            var bulkIndexer = new BulkDescriptor();

            
            foreach (var document in city)
            {
                bulkIndexer.Index<City>(i => i
                    .Document(document)
                    .Id(document.GuidNo)
                    .Index("loglama"));
            }

            elasticClient.Bulk(bulkIndexer);


        }
 
































        // CreateNewIndex();


        //ElasticsearchVerileri elasticsearchVerileri = new ElasticsearchVerileri();


        //elasticsearchVerileri.AddNewIndex(new City 
        //{ID=1,Name= "delhi1",State= "delhi1",Country= "India1",Population= "9.879 million1" });
        //elasticsearchVerileri.AddNewIndex(new City
        //{ ID = 1, Name = "delhi2", State = "delhi2", Country = "India2", Population = "9.879 million2" });
        //elasticsearchVerileri.AddNewIndex(new City
        //{ ID = 1, Name = "delhi3", State = "delhi3", Country = "India3", Population = "9.879 million3" });
        //elasticsearchVerileri.AddNewIndex(new City
        //{ ID = 1, Name = "delhi4", State = "delhi4", Country = "India4", Population = "9.879 million4" });
        //elasticsearchVerileri.AddNewIndex(new City
        //{ ID = 1, Name = "delhi5", State = "delhi5", Country = "India5", Population = "9.879 million5" });
        //elasticsearchVerileri.AddNewIndex(new City
        //{ ID = 1, Name = "delhi6", State = "delhi6", Country = "India6", Population = "9.879 million6" });






    }
        //public static void CreateNewIndex()
        //{
        //    ElasticClient client = null;
        //    var createIndexDescriptor = new CreateIndexDescriptor("product")
        //  .Mappings(ms => ms
        //                  .Map<Product>(m => m.AutoMap())
        //           )
        //   .Aliases(a => a.Alias("bora_blog"));
        //    var uri = new Uri("http://localhost:9200");
        //    var settings = new ConnectionSettings(uri);
        
        //    client = new ElasticClient(settings);
        //    var response = client.CreateIndex(createIndexDescriptor);



        //    //settings.DefaultIndex("defaultindex")
        //    //    .MapDefaultTypeIndices(m => m.Add(typeof(Post), "my_blog"));

        //    //client = new ElasticClient(settings);
        //}


     
    
}
