using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elastictest.EntityFramework
{
    public class ElasticsearchVerileri
    {
        ElasticClient client = null;
        public ElasticsearchVerileri()
        {
           
            var createIndexDescriptor = new CreateIndexDescriptor("")
          .Mappings(ms => ms
                          .Map<City>(m => m.AutoMap())
                   )
           .Aliases(a => a.Alias("bora_blog"));
            var uri = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(uri);

            client = new ElasticClient(settings);
            var response = client.CreateIndex(createIndexDescriptor);




            //var uri = new Uri("http://localhost:9200");
            //var settings = new ConnectionSettings(uri);
            //client = new ElasticClient(settings);
            //settings.DefaultIndex("verilerigoster");
        }
        public List<City> GetResult()
        {
            if (client.IndexExists("verilerigoster").Exists)
            {
                var response = client.Search<City>();
                return response.Documents.ToList();
            }
            return null;
        }

        public List<City> GetResult(string condition)
        {
            if (client.IndexExists("verilerigoster").Exists)
            {
                var query = condition;

                return client.SearchAsync<City>(s => s
                .From(0)
                .Take(10)
                .Query(qry => qry
                    .Bool(b => b
                        .Must(m => m
                            .QueryString(qs => qs
                                .DefaultField("_all")
                                .Query(query)))))).Result.Documents.ToList();
            }
            return null;
        }

        public void AddNewIndex(City model)
        {
            client.IndexAsync<City>(model, null);
        }
    }
}
