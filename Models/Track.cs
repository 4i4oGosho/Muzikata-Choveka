namespace MuzikataIChoveka.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public double FrequencyHz { get; set; }  // звукова вибрация / честота
        public string? AudioUrl { get; set; }    // линк към аудио файл
    }
}
