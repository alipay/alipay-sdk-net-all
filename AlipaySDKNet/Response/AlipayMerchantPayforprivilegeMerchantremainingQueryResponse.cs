using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMerchantremainingQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeMerchantremainingQueryResponse : AopResponse
    {
        /// <summary>
        /// 消费者未使用的权益金部分
        /// </summary>
        [XmlElement("unused_benefit")]
        public string UnusedBenefit { get; set; }

        /// <summary>
        /// 消费者尚未使用的本金部分
        /// </summary>
        [XmlElement("unused_principal")]
        public string UnusedPrincipal { get; set; }

        /// <summary>
        /// 消费者已使用的权益金部分
        /// </summary>
        [XmlElement("used_benefit")]
        public string UsedBenefit { get; set; }

        /// <summary>
        /// 消费者已使用的本金部分
        /// </summary>
        [XmlElement("used_principal")]
        public string UsedPrincipal { get; set; }
    }
}
