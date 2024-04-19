using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvOcrVatinvoiceIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvOcrVatinvoiceIdentifyModel : AopObject
    {
        /// <summary>
        /// 目前只支持pdf、jpg两种file_type的识别能力，根据具体传入的发票的格式传入正确的值
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件二进制内容 + base64
        /// </summary>
        [XmlElement("image_raw")]
        public string ImageRaw { get; set; }

        /// <summary>
        /// 图片下载url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 服务调用来源(需要咨询服务提供方)
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 单次调用唯一标示，用于异常问题排查，调用方需要负责生成并且记录在调用日志里
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
