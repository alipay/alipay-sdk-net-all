using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardDeductionorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 核销订单信息
        /// </summary>
        [XmlElement("deduction_order_info")]
        public DeductionOrderInfo DeductionOrderInfo { get; set; }
    }
}
