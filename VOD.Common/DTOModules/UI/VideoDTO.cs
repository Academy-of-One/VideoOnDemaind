using System;
using System.Collections.Generic;
using System.Text;

namespace VOD.Common.DTOModules.UI
{
    public class VideoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string ThumbNail { get; set; }
        public string URL { get; set; }
    }
}
