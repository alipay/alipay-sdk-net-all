using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsAgreementDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsAgreementDTO : AopObject
    {
        /// <summary>
        /// 条款内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 条款名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 条款类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 条款链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
