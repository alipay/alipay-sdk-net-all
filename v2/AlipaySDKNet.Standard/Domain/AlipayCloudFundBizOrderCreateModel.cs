using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundBizOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundBizOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 行业信息
        /// </summary>
        [XmlElement("biz_industry")]
        public string BizIndustry { get; set; }

        /// <summary>
        /// 用户在平台的userID，若来源是支付宝，就填支付宝的uid，否则传对应平台的uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户在平台ID，若来源是支付宝，就填支付宝的openid，否则传对应平台的用户id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 订单扩展信息包括收单方分账smid、收单人钱包id、收件人地址信息、发件人地址信息、物流信息等
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 商品明细列表，商品id：itemId、skuId、itemNum、amount、realAmount 等等
        /// </summary>
        [XmlArray("item_detail")]
        [XmlArrayItem("string")]
        public List<string> ItemDetail { get; set; }

        /// <summary>
        /// 履约状态：等待履约、履约中、履约完成
        /// </summary>
        [XmlElement("logistic_status")]
        public string LogisticStatus { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_created_time")]
        public string OrderCreatedTime { get; set; }

        /// <summary>
        /// 订单号，当source=ALIPAY时，需传入支付宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单履约状态：已下单、履约中、履约完成、退货中、已退货
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 在支付宝侧的支付单号
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付状态：等待支付、支付中、支付完成、支付失败
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 收单方支付宝uid，用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 当账号类型为open_id时必选，传入支付宝的openId
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 订单服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 订单来源平台
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 本次订单的内容标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }
    }
}
