using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace perceptron
{
    public class Data
    {
        public double[] Input { get; set; }
        public int Output { get; set; }

        public List<Data> LoadData()
        {
            return JsonConvert.DeserializeObject<List<Data>>(File.ReadAllText(@"Data.json"));
        }
    }
}
