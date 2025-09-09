using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderUseResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardDeductionorderUseResponse : AopResponse
    {
        /// <summary>
        /// 核销订单id
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }
    }
}
