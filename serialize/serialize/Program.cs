using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace serialize
{
    public class cereal
    {
        public string name { get; set; }
        public string slogan { get; set; }
        public Boolean clarkeapproved { get; set; }
        public int calories { get; set; }
        public decimal price { get; set; }
        public string picture { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cereal luckycharms = new cereal();
            luckycharms.name = "lucky charms";
            luckycharms.slogan = "they're magically delicious";
            luckycharms.clarkeapproved = true;
            luckycharms.price = 5.49m;
            luckycharms.calories = 137;

            cereal frootloops = new cereal();
            frootloops.name = "froot loops";
            frootloops.slogan = "whatever froots your loops";
            frootloops.clarkeapproved = true;
            frootloops.price = 8.96m;
            frootloops.calories = 150;

            cereal fruitypebbles = new cereal();
            fruitypebbles.name = "fruity pebbles";
            fruitypebbles.slogan = "rocks your whole mouth";
            fruitypebbles.clarkeapproved = true;
            fruitypebbles.price = 5.29m;
            fruitypebbles.calories = 120;

            string jsonString = JsonSerializer.Serialize(fruitypebbles);
            Console.WriteLine(jsonString);

            cereal fruity = new cereal();
            fruity = JsonSerializer.Deserialize<cereal>(jsonString);

            Console.ReadKey();
        }
    }
}
