using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvatarHumanTaskResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AvatarHumanTaskResultDTO : AopObject
    {
        /// <summary>
        /// 视频时长，单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 报错信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 视频url
        /// </summary>
        [XmlElement("final_video_url")]
        public string FinalVideoUrl { get; set; }

        /// <summary>
        /// 视频id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 封面图url
        /// </summary>
        [XmlElement("preview")]
        public string Preview { get; set; }

        /// <summary>
        /// 当前视频查询结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [XmlElement("video_name")]
        public string VideoName { get; set; }

        /// <summary>
        /// 视频格式
        /// </summary>
        [XmlElement("video_type")]
        public string VideoType { get; set; }
    }
}
