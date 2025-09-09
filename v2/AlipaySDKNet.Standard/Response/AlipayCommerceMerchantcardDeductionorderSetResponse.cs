using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderSetResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardDeductionorderSetResponse : AopResponse
    {
        /// <summary>
        /// (1) 当 card_type=AXF_MONEY_TIME_CARD && operation_type=REFUND 时，该字段代表退款单id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
