using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderAftersaleCreateResponse.
    /// </summary>
    public class AlipayCommerceRentOrderAftersaleCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝售后单ID
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 商户外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("aftersale_pay_item_v_o")]
        public List<AftersalePayItemVO> PayItems { get; set; }

        /// <summary>
        /// 退款费用项明细
        /// </summary>
        [XmlArray("refund_items")]
        [XmlArrayItem("aftersale_refund_item_v_o")]
        public List<AftersaleRefundItemVO> RefundItems { get; set; }
    }
}
