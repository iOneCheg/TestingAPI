namespace TestingAPI.Models
{
    public class GameTurnRequest
    {
        public string Game_id { get; set; }

        public int col { get; set; }
        public int row { get; set; }
    }
}
