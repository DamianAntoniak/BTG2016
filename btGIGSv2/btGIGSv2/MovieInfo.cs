using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaInfoLib;


namespace btGIGSv2
{
    class MovieInfo : MediaInfo
    {

        private string videoCodec = "";
        private string bitRateVideo = "";
        private string resolution = "";
        private string fps = "";
        private string time = "";

        public MovieInfo(string path)
        {
            GetInfo(path);
        }

        private void GetInfo(string path)
        {
            base.Open(@path);

            videoCodec = base.Get(StreamKind.Video, 0, "Format");
            if (videoCodec == "MPEG-4 Visual") videoCodec = "MPEG-4";
            else videoCodec = "x264";

            bitRateVideo = base.Get(StreamKind.Video, 0, "BitRate/String");
            resolution = String.Format("{0} x {1}({2})", 
                    base.Get(StreamKind.Video, 0, "Width"), 
                    base.Get(StreamKind.Video, 0, "Height"), 
                    base.Get(StreamKind.Video, 0, "DisplayAspectRatio/String"));

            fps = base.Get(StreamKind.Video, 0, "FrameRate/String");

            time = base.Get(StreamKind.Video, 0, "Duration/String4");

            time = String.Format("{0}h {1}min {2}sec",
                    (time.Substring(0, 1) == "0" ? time.Substring(1, 1) : time.Substring(0, 2)),
                    (time.Substring(3, 1) == "0" ? time.Substring(4, 1) : time.Substring(3, 2)),
                    (time.Substring(6, 1) == "0" ? time.Substring(7, 1) : time.Substring(6, 2)));
        }

        public string VideoCodec
        {
            get
            {
                return videoCodec;
            }
        }

        public string BitRateVideo
        {
            get
            {
                return bitRateVideo;
            }
        }

        public string Resolution
        {
            get
            {
                return resolution;
            }
        }

        public string FPS
        {
            get
            {
                return String.Format("{0} fps", fps.Substring(0, fps.IndexOf(" ")));
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
        }
    }
}
