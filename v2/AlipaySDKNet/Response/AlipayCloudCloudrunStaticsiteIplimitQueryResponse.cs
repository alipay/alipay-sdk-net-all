using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteIplimitQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteIplimitQueryResponse : AopResponse
    {
        /// <summary>
        /// IP黑白名单配置
        /// </summary>
        [XmlElement("ip_limit")]
        public IPLimit IpLimit { get; set; }
    }
}
