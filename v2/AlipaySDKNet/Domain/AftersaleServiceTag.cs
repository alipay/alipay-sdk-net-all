using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleServiceTag Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleServiceTag : AopObject
    {
        /// <summary>
        /// 服务标签的编码
        /// </summary>
        [XmlElement("service_tag_code")]
        public string ServiceTagCode { get; set; }

        /// <summary>
        /// 服务标签名称。
        /// </summary>
        [XmlElement("service_tag_name")]
        public string ServiceTagName { get; set; }
    }
}
