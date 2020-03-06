using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMemberremainingQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeMemberremainingQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额中未使用的权益金部分
        /// </summary>
        [XmlElement("unused_benefit")]
        public string UnusedBenefit { get; set; }

        /// <summary>
        /// 余额中未使用的本金部分
        /// </summary>
        [XmlElement("unused_principal")]
        public string UnusedPrincipal { get; set; }
    }
}
