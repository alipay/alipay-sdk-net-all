using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPaySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPaySyncModel : AopObject
    {
        /// <summary>
        /// 租赁售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租金支付外部请求号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 订单费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("rent_pay_item_d_t_o")]
        public List<RentPayItemDTO> PayItems { get; set; }

        /// <summary>
        /// 对应支付渠道的支付单号，ALIPAY时必传
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
