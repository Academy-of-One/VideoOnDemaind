using System;
using System.Collections.Generic;
using System.Text;

namespace VOD.Common.DTOModules.UI
{
    public class LessonInfoDTO
    {
        public int LessonNumber { get; set; }
        public int NumberofLessons { get; set; }
        public int PreviousVideoId { get; set; }
        public string NextVideoId { get; set; }
        public string  NextVideoTitle { get; set; }
        public string NextVideoThumbnail { get; set; }
    }
}
