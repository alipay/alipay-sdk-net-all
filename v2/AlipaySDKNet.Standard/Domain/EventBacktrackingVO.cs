using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EventBacktrackingVO Data Structure.
    /// </summary>
    [Serializable]
    public class EventBacktrackingVO : AopObject
    {
        /// <summary>
        /// 支付宝内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容物抓取时间,格式 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("content_time")]
        public string ContentTime { get; set; }

        /// <summary>
        /// 内容格式  ● PIC
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 上传时间 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("content_upload_time")]
        public string ContentUploadTime { get; set; }

        /// <summary>
        /// 检测结果： ● 有风险 ● 无风险
        /// </summary>
        [XmlElement("detect_result")]
        public string DetectResult { get; set; }

        /// <summary>
        /// 检测状态： ● 检测中 ● 检测完成
        /// </summary>
        [XmlElement("detect_status")]
        public string DetectStatus { get; set; }

        /// <summary>
        /// 内容访问Url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 外部内容唯一ID
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }
    }
}
