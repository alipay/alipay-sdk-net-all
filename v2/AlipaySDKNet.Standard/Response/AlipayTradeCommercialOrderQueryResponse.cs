using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCommercialOrderQueryResponse.
    /// </summary>
    public class AlipayTradeCommercialOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 该笔订单在支付机构侧的交易单号，可用于后续对账使用
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 本次订单关联的价格id
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 本次订单关联的商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
