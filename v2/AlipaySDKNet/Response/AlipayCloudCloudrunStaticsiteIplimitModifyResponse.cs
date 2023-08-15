using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteIplimitModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteIplimitModifyResponse : AopResponse
    {
        /// <summary>
        /// IP黑白名单配置
        /// </summary>
        [XmlElement("ip_limit")]
        public IPLimit IpLimit { get; set; }
    }
}
