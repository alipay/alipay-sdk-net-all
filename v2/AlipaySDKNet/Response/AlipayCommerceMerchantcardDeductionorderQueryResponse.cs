using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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

        /// <summary>
        /// 核销订单退款明细列表
        /// </summary>
        [XmlArray("deduction_refund_order_info_list")]
        [XmlArrayItem("deduction_refund_order_info")]
        public List<DeductionRefundOrderInfo> DeductionRefundOrderInfoList { get; set; }
    }
}
