using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateRequest : AopObject
    {
        /// <summary>
        /// 身份认证
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 频道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 提交的图片内容
        /// </summary>
        [XmlArray("materials")]
        [XmlArrayItem("string")]
        public List<string> Materials { get; set; }

        /// <summary>
        /// 常量值
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 来源标识，目前支持好大夫
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 认证值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
