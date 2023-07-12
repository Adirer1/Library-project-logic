using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library_project_logic
{
    public static class ItemManager
    {
        public static Dictionary<Guid,Item> ItemsDict = new Dictionary<Guid, Item>();
        static ItemManager()
        {
            Directory.CreateDirectory("Items");

            foreach (string file in Directory.EnumerateFiles("Items", "*.json"))
            {
                Item item;
                string json = File.ReadAllText(file);
                if (json.Contains("Author"))
                {
                     item = JsonConvert.DeserializeObject<Book>(json);
                }
                else
                {
                     item = JsonConvert.DeserializeObject<Magazine>(json);
                }
                ItemsDict.Add(item.Isbn, item);
            }
        }


        public static void AddItem( Item item)
        {
            ItemsDict.Add(item.Isbn, item);
            string json = JsonConvert.SerializeObject(item, Formatting.Indented);
            string fileName = "Items\\" + item.Title+ " "+item.Isbn + ".json";
            File.WriteAllText(fileName, json);
        }
        public static void DeleteItem(Item item)
        {
            ItemsDict.Remove(item.Isbn);
            File.Delete("Items\\" + item.Title + " " + item.Isbn + ".json");
        }
        public static void EditItem( Item item, string oldTitle)
        {
            File.Delete("Items\\" + oldTitle + " " + item.Isbn + ".json");
            string json = JsonConvert.SerializeObject(item, Formatting.Indented);
            string fileName = "Items\\" + item.Title + " " + item.Isbn + ".json";
            File.WriteAllText(fileName, json);
        }
    }
    public delegate void ItemDelegate(Item item);
   
}
