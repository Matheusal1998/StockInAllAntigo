namespace IAStockInAll.Model
{
    public class Prediction
    {
        public double Probability { get; set; }
        public string TagId { get; set; }
        public string TagName { get; set; }
        public string topIntent { get; set; }
        public Entities entities { get; set; }
    }
}
