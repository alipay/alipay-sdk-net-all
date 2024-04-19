using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanLbscrowdCreateResponse.
    /// </summary>
    public class AlipayMerchantQipanLbscrowdCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}
