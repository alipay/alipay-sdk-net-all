using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderPayInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderPayInfoVO : AopObject
    {
        /// <summary>
        /// 租赁售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租赁订单支付外部请求号，由商家自定义
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 主动同步支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付费项明细
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("rent_pay_item_v_o")]
        public List<RentPayItemVO> PayItems { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_method")]
        public string PayMethod { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
