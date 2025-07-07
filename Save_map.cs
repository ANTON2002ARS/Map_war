using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Map_war
{
    
    public class Save_Map
    {
        public  void SaveMapDataToFile(string filePath, MapData data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public MapData LoadMapDataFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return new MapData();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<MapData>(json) ?? new MapData();
        }        
    }
}