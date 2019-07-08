using System;
using System.Collections.Generic;
using System.Text;

namespace VOD.Common.DTOModules.UI
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public int CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public string MarqueeImageUrl { get; set; }
        public string CourseImageUrl { get; set; }
    }
}
