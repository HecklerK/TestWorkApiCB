namespace TestWorkApiCB.Models
{
    public class Daily
    {
        public DateTime Date { get; set; }
        public DateTime PreviousData { get; set; }
        public string PreviousURL { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, Valute> Valute { get; set; } = new Dictionary<string, Valute>();
    }
}
