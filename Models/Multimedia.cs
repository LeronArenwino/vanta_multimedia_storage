using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vanta_multimedia_storage.Models
{
    public class Multimedia
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public double size { get; set; }
        public string location { get; set; }

    }
}
