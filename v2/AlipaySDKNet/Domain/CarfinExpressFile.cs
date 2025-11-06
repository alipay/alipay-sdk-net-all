using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinExpressFile Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinExpressFile : AopObject
    {
        /// <summary>
        /// 支付宝开放平台文件AFTSID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件标签（文件类型下的细分）
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
