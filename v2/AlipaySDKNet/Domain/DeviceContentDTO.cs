using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceContentDTO : AopObject
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
        /// 内容格式：PIC
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 上传时间 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("content_upload_time")]
        public string ContentUploadTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("detect_results")]
        [XmlArrayItem("detect_result")]
        public List<DetectResult> DetectResults { get; set; }

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
