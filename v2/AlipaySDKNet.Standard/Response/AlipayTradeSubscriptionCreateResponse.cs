using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionCreateResponse.
    /// </summary>
    public class AlipayTradeSubscriptionCreateResponse : AopResponse
    {
        /// <summary>
        /// 长链，适用于跳转拉起支付宝端
        /// </summary>
        [XmlElement("alipay_jump_schema")]
        public string AlipayJumpSchema { get; set; }

        /// <summary>
        /// 短链，适用于生成二维码
        /// </summary>
        [XmlElement("alipay_schema")]
        public string AlipaySchema { get; set; }

        /// <summary>
        /// 创建订阅时生成的支付请求单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订阅创建生成的优惠信息
        /// </summary>
        [XmlElement("promotion_info")]
        public string PromotionInfo { get; set; }

        /// <summary>
        /// 签约链接有效期截止时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("schema_effective_end")]
        public string SchemaEffectiveEnd { get; set; }

        /// <summary>
        /// 订阅id，本次订阅操作生成的唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 试用期结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trial_end")]
        public string TrialEnd { get; set; }

        /// <summary>
        /// 试用期开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trial_start")]
        public string TrialStart { get; set; }
    }
}
