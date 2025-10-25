namespace MuzikataIChoveka.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }       // ���� � ������ ������������
        public int TrackId { get; set; }         // ��� ���� � ������
        public Track Track { get; set; }         // ������ ��� ������ Track
        public int MoodId { get; set; }          // ����� ���������� � ����
        public Mood Mood { get; set; }           // ������ ��� ������ Mood
    }
}
