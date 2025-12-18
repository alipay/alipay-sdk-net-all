using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PBCScanParam Data Structure.
    /// </summary>
    [Serializable]
    public class PBCScanParam : AopObject
    {
        /// <summary>
        /// 证件信息
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称，包含人名与企业名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
