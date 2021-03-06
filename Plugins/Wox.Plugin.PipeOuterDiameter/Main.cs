using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wox.Plugin.PipeOutsideDiameter
{
    public class PipeOutsideDiameter : IPlugin
    {
        private string _jsonFile;

        public void Init(PluginInitContext context)
        {
            _jsonFile = Path.Combine(context.CurrentPluginMetadata.PluginDirectory, "data.json");
        }

        public List<Result> Query(Query query)
        {
            var search = query.Search.Trim().ToLower();
            var results = new List<Result>();
            //search = "50";
            var data = ReadJsonFile<Dictionary<string, string[]>>(_jsonFile);
            if (data != null && data.ContainsKey(search))
            {
                results.Add(new Result() { Title = $"{data[search].GetValue(0)}", SubTitle = "I系列（英制）" });
                results.Add(new Result() { Title = $"{data[search].GetValue(1)}", SubTitle = "II系列（公制）" });
            }

            results.ForEach(x => x.Action =
                _ =>
                {
                    Clipboard.SetDataObject(x.Title);
                    return true;
                }
            );

            return results;
        }

        private T ReadJsonFile<T>(string fileName)
        {
            var content = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
