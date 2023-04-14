using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialGiftOrderQueryResponse.
    /// </summary>
    public class AlipaySocialGiftOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 礼物单状态：  等待领取：WAIT_RECEIVE  已经领取：RECEIVED  领取失败 ： RECEIVE_ERROR    礼物单和订单状态是不同的。订单主要涉及支付退款状态，而礼物单状态则是用户接受礼物的状态。
        /// </summary>
        [XmlElement("gift_order_status")]
        public string GiftOrderStatus { get; set; }

        /// <summary>
        /// 订单状态：  已支付：PAY_SUCCESS  已退款：REFUND_SUCCESS
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 收礼方id
        /// </summary>
        [XmlElement("receiver_id")]
        public string ReceiverId { get; set; }

        /// <summary>
        /// 送礼方id
        /// </summary>
        [XmlElement("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// 对应送礼平台的sku_id，可用于找到送礼平台对应配置的产品，库存等信息。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 卡码信息
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
