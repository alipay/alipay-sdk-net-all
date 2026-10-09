using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchoolserviceModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateSchoolserviceModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回的服务唯一Id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
