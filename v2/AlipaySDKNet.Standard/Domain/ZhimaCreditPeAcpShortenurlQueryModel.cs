using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeAcpShortenurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeAcpShortenurlQueryModel : AopObject
    {
        /// <summary>
        /// 原始链接
        /// </summary>
        [XmlElement("schema_url")]
        public string SchemaUrl { get; set; }
    }
}
