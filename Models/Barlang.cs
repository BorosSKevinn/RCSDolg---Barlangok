namespace RCSDolg.Models
{
    public class Barlang
    {
        public int Id { get; set; }
        public string Nev { get; set; } = string.Empty;
        public double Hossz { get; set; }
        public double Kiterjedes { get; set; }
        public double Melyseg { get; set; }
        public double Magassag { get; set; }
        public string Telepules { get; set; } = string.Empty;
    }
}
