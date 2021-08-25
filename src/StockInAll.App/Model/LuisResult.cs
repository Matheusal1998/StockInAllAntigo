using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAStockInAll.Model
{
    public class LuisResult
    {
        public string query { get; set; }
        public Prediction prediction { get; set; }
    }
    public class Entities
    {
        public List<string> Campo { get; set; }
        public List<string> Valor { get; set; }
    }
}
