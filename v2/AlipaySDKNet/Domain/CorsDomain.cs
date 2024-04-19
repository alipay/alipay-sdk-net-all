using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorsDomain Data Structure.
    /// </summary>
    [Serializable]
    public class CorsDomain : AopObject
    {
        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }
    }
}
