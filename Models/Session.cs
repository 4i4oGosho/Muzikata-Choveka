namespace MuzikataIChoveka.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }       // кога е слушал потребителят
        public int TrackId { get; set; }         // кой трак е избрал
        public Track Track { get; set; }         // връзка към обекта Track
        public int MoodId { get; set; }          // какво настроение е имал
        public Mood Mood { get; set; }           // връзка към обекта Mood
    }
}
