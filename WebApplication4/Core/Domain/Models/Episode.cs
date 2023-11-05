namespace WebApplication4.Core.Domain.Models
{
    public class Episode

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string air_date { get; set; }
        public string episode { get; set; }
        public string created { get; set; }
        public List<Character> Characters { get; set; }
    }
}
