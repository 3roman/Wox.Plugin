using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace Wox.Plugin.PressureRatingConverter
{
    public class PressureRatingConverter : IPlugin
    {
        private string _jsonFile;
        private const string CLASS_PATTERN = @"cl\s+([0-9]+)";
        private const string PN_PATTERN = @"pn\s+([0-9.]+)";

        public void Init(PluginInitContext context)
        {
            _jsonFile = Path.Combine(context.CurrentPluginMetadata.PluginDirectory, "data.json");
        }

        public List<Result> Query(Query query)
        {
            var raw = query.Search.Trim().ToLower();
            var results = new List<Result>();
            if (raw.StartsWith(@"cl") &&
                string.IsNullOrWhiteSpace(raw.Replace(@"cl", string.Empty)))
            {
                foreach (var item in ReadJsonFile<Dictionary<string, string>>(_jsonFile))
                {
                    results.Add(new Result() { Title = item.Value });
                }

                return results;
            }
            if (raw.StartsWith(@"pn") &&
                string.IsNullOrWhiteSpace(raw.Replace(@"pn", string.Empty)))
            {
                foreach (var item in ReadJsonFile<Dictionary<string, string>>(_jsonFile))
                {
                    results.Add(new Result() { Title = item.Key });
                }

                return results;
            }
            else if (Regex.IsMatch(raw, CLASS_PATTERN))
            {
                var oldPR = Regex.Match(raw, CLASS_PATTERN).Groups[1].Value;
                var newPR = ConvertPressureRating(oldPR);
                results.Add(new Result() { Title = $"PN{newPR}" });

                return results;
            }
            else if (Regex.IsMatch(raw, PN_PATTERN))
            {
                var oldPR = Regex.Match(raw, PN_PATTERN).Groups[1].Value;
                var newPR = ConvertPressureRating(oldPR, false);
                results.Add(new Result() { Title = $"CL{newPR}" });

                return results;
            }

            return results;
        }

        public string ConvertPressureRating(string pressureRating, bool isClass2PN = true)
        {
            var data = ReadJsonFile<Dictionary<string, string>>(_jsonFile);
            if (isClass2PN)
            {
                var key = data.Where(x => x.Value == pressureRating).FirstOrDefault().Key;
                return key;
            }
            else
            {
                var value = data.Where(x => x.Key == pressureRating).FirstOrDefault().Value;
                return value;
            }
        }

        private T ReadJsonFile<T>(string fileName)
        {
            var content = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
