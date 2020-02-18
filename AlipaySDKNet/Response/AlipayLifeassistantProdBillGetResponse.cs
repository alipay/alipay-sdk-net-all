using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayLifeassistantProdBillGetResponse.
    /// </summary>
    public class AlipayLifeassistantProdBillGetResponse : AopResponse
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付款项名称
        /// </summary>
        [XmlElement("order_item")]
        public string OrderItem { get; set; }

        /// <summary>
        /// 支付时间，毫秒
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 付款类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 收款方名称|机构名称
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 交易类型  S——担保交易  FP——即时到帐  COD——货到付款
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
