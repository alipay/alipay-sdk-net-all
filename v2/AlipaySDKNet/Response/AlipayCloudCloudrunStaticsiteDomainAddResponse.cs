using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomainAddResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteDomainAddResponse : AopResponse
    {
        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain")]
        public StaticDomain Domain { get; set; }
    }
}
