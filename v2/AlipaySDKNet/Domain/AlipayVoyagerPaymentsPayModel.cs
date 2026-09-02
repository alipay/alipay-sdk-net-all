using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerPaymentsPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerPaymentsPayModel : AopObject
    {
        /// <summary>
        /// 环境信息
        /// </summary>
        [XmlElement("env")]
        public VoyagerEnvInfo Env { get; set; }

        /// <summary>
        /// 过期时间，UTC+8，ISO 8601格式
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 行业标识，字段类型与请求参数对应
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 主站网关的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order")]
        public VoyagerOrderInfoDTO Order { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public MultiCurrencyMoneyDTO PaymentAmount { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("payment_method")]
        public VoyagerPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// 支付完成回执地址（飞猪回调地址）
        /// </summary>
        [XmlElement("payment_notify_url")]
        public string PaymentNotifyUrl { get; set; }

        /// <summary>
        /// 支付成功跳转地址
        /// </summary>
        [XmlElement("payment_redirect_url")]
        public string PaymentRedirectUrl { get; set; }

        /// <summary>
        /// 支付请求ID，幂等key
        /// </summary>
        [XmlElement("payment_request_id")]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// 支付结算策略
        /// </summary>
        [XmlElement("settlement_strategy")]
        public SettlementStrategyDTO SettlementStrategy { get; set; }

        /// <summary>
        /// 用户id，用来接受openId的转换
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
