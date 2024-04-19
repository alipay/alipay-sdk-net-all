using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceZhimaSubmerchantQueryResponse.
    /// </summary>
    public class AlipayCommerceZhimaSubmerchantQueryResponse : AopResponse
    {
        /// <summary>
        /// 本次进件工单失败的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户进件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
