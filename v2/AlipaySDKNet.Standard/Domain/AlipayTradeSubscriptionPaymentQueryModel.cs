using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionPaymentQueryModel : AopObject
    {
        /// <summary>
        /// 筛选支付成功的截止时间（筛选时不包含该时刻），按照返回结果的gmt_occur为筛选目标；不传默认为当天截止时间不传默认为当天截止时间，如2026-06-30 23:59:59。开始时间和截止时间不能超过31天。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页页数，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，不传，默认20；最大50
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 筛选支付成功的开始时间（筛选时包含该时刻），按照返回结果的gmt_occur为筛选目标；不传默认为当天的凌晨如2026-06-30 00:00:00。开始时间和截止时间不能超过31天。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 需要查询的支付流水对应的订阅ID
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
