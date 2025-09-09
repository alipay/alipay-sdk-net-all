using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorPlanBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorPlanBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 荣耀侧借款订单号，不传则查询所有待还计划
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 荣耀用户ID
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部追踪ID
        /// </summary>
        [XmlElement("out_trace_id")]
        public string OutTraceId { get; set; }

        /// <summary>
        /// 请求来源 CUSTOMER-C端对应用户发起、SCHEDULER-调度发起、BACKDOOR-小二对应后台用户调用
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }
    }
}
