using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityGetResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityGetResponse : AopResponse
    {
        /// <summary>
        /// 支付能力返回结果信息
        /// </summary>
        [XmlElement("payment_ability_query_response")]
        public PaymentAbilityQueryResponse PaymentAbilityQueryResponse { get; set; }
    }
}
