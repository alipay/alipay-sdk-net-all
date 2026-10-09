using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInstEquityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayInstEquityInfo : AopObject
    {
        /// <summary>
        /// 权益可用开始时间，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2024-05-08T13:29:35.120+08:00表示，北京时间2024年5月8日 13点29分35秒。
        /// </summary>
        [XmlElement("available_begin_time")]
        public string AvailableBeginTime { get; set; }

        /// <summary>
        /// 权益可用结束时间，遵循rfc3339标准格式，格式为yyyy-MM-DDTHH:mm:ss.sss+TIMEZONE，yyyy-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2024-05-08T13:29:35.120+08:00表示，北京时间2024年5月8日 13点29分35秒。
        /// </summary>
        [XmlElement("available_end_time")]
        public string AvailableEndTime { get; set; }

        /// <summary>
        /// 权益所属的摩斯营销活动ID
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 权益金额，单位：分
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 发放成功后生成的发放凭证号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 权益状态： SENDED：可用 USED：已实扣
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益使用门槛金额，单位：分
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 微信支付系统生成的订单号
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 用户ID信息，该字段拼接方式：appID#openID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
