using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardPayOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StandardPayOrderDTO : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 授权id，cn这边和userId对应
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态，与响应类型保持一致，非枚举返回
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public MultiCurrencyMoneyDTO PaymentAmount { get; set; }

        /// <summary>
        /// 支付请求单号
        /// </summary>
        [XmlElement("payment_request_id")]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
