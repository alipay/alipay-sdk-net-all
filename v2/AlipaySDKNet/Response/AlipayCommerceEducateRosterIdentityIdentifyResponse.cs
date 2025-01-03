using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRosterIdentityIdentifyResponse.
    /// </summary>
    public class AlipayCommerceEducateRosterIdentityIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 服务商接口信息
        /// </summary>
        [XmlElement("isv_msg")]
        public string IsvMsg { get; set; }
    }
}
