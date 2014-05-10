using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniversity
{
    class Structure
    {
        public string UniqueId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public Structure(string uniqueId, string image, string title, string subtitle)
        {
            this.UniqueId = uniqueId;
            this.Image = image;
            this.Title = title;
            this.Subtitle = subtitle;
        }
    }
}
