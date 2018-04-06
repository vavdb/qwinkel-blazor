using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qwinkel.Shared.Producten
{
    public class Afbeelding
    {
        public int id { get; set; }
        public string filePath { get; set; }
    }

    public class Content
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string omschrijving { get; set; }
        public double prijs { get; set; }
        public double btw { get; set; }
        public string youtubeUrl { get; set; }
        public Afbeelding afbeelding { get; set; }
    }

    public class RootObject
    {
        public int totalElements { get; set; }
        public int totalPages { get; set; }
        public object sort { get; set; }
        public bool first { get; set; }
        public bool last { get; set; }
        public int numberOfElements { get; set; }
        public int size { get; set; }
        public List<Content> content { get; set; }
        public int number { get; set; }
    }
}
