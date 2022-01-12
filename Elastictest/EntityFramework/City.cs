using System;
using System.Collections.Generic;
using System.Text;

namespace Elastictest.EntityFramework
{
    public class City
    {
        public City()
        {
            GuidNo = Guid.NewGuid();
        }
        public Guid GuidNo
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string Population
        {
            get;
            set;
        }

        //ElasticClient client = null;
        //Console.WriteLine("Hello World!");
        //var uri = new Uri("http://localhost:9200");
        //var settings = new ConnectionSettings(uri);
        //client = new ElasticClient(settings);
        //settings.DefaultIndex("city");

        //List<City> city = new List<City>();
        //city.Add(new City
        //{
        //    ID=1,
        //    Name="delhi",
        //    State= "delhi",
        //    Country="India",
        //    Population= "9.879 million"
        //});
        //city.Add(new City
        //{
        //    ID = 2,
        //    Name = "mumbai",
        //    State= "Maharashtra",
        //    Country = "India",
        //    Population = "11.98 million"
        //});
        //city.Add(new City
        //{
        //    ID = 3,
        //    Name = "chenai",
        //    State= "Tamil Nadu",
        //    Country = "India",
        //    Population = "4.334 million"
        //});
        //city.Add(new City
        //{
        //    ID = 4,
        //    Name = "kolkata",
        //    State= "W. Bengal",
        //    Country = "India",
        //    Population = "4.573 million"
        //});
    }
}
