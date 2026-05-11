using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderAftersaleConfirmResponse.
    /// </summary>
    public class AlipayCommerceRentOrderAftersaleConfirmResponse : AopResponse
    {
        /// <summary>
        /// 费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("aftersale_pay_item_v_o")]
        public List<AftersalePayItemVO> PayItems { get; set; }

        /// <summary>
        /// 退款费用项明细列表
        /// </summary>
        [XmlArray("refund_items")]
        [XmlArrayItem("aftersale_refund_item_v_o")]
        public List<AftersaleRefundItemVO> RefundItems { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
