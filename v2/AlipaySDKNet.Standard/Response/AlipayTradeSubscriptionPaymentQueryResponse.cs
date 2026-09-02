using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionPaymentQueryResponse.
    /// </summary>
    public class AlipayTradeSubscriptionPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 筛选支付流水的截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("payment_details")]
        [XmlArrayItem("subscription_payment_detail")]
        public List<SubscriptionPaymentDetail> PaymentDetails { get; set; }

        /// <summary>
        /// 筛选支付流水的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 需要查询的支付流水对应的订阅ID
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 筛选范围内支付明细总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
