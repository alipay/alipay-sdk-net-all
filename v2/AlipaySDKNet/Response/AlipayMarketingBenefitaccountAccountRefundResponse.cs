using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountRefundResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountAccountRefundResponse : AopResponse
    {
        /// <summary>
        /// 总退款金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 退款操作单号，可用于幂等
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
