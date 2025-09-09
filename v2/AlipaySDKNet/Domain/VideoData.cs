using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VideoData Data Structure.
    /// </summary>
    [Serializable]
    public class VideoData : AopObject
    {
        /// <summary>
        /// 当前视频时长，单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 第几集
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 第三方系统为每个视频生成的全局唯一标识，用于在各系统之间精确定位同一条视频数据，便于后期排查问题。建议仅包含字母、数字、下划线或短横线，如果缺失或为空，接口将返回参数缺失错误，平台不会替调用方自动生成
        /// </summary>
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频文件名称
        /// </summary>
        [XmlElement("video_name")]
        public string VideoName { get; set; }

        /// <summary>
        /// 需要同步视频的OSS地址
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }
    }
}
