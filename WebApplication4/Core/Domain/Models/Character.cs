using Microsoft.AspNetCore.Components.Routing;

namespace WebApplication4.Core.Domain.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string origin { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public List<Episode> episodes { get; set; }
    }
}
