using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcVulQueryModel : AopObject
    {
        /// <summary>
        /// 漏洞id
        /// </summary>
        [XmlElement("vul_id")]
        public long VulId { get; set; }
    }
}
