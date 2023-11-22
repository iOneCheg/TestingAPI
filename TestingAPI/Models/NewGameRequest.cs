namespace TestingAPI.Models
{
    public enum Type
    {
       Empty,
       One,
       Two,
       Three,
       Four,
       Five
    }
    public class NewGameRequest
    {
        /// <summary>
        /// Ширина игрового поля
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Высота игрового поля
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Количество мин на поле
        /// </summary>
        public int Mines_count { get; set; }
    }

    public class GameInfoResponse
    {
        public string? Game_id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Mines_count { get; set; }
        public bool Completed { get; set; }

        public string[][]? Field { get; set; }
    }
    public class ErrorResponse
    {
        public string Error { get; set; }
    }
}
