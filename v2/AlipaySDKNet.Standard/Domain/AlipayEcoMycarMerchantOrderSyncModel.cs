using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMerchantOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMerchantOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号。若交易发生在只支付宝端内（pay_channel=ALIPAY）时则必传。
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 请联系车生活解决方案产品同学沟通需要传的字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 请联系车生活车生活产品技术确认订单状态枚举
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 接入前请跟车生活产品技术确认订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户侧订单号。车生活通过user_id+partner_id+out_order_no作为订单唯一约束
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户侧下单时间
        /// </summary>
        [XmlElement("out_order_time")]
        public string OutOrderTime { get; set; }

        /// <summary>
        /// 商户pid，若不传，则使用请求此openapi接口的商户账号的pid作为订单pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户实付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
