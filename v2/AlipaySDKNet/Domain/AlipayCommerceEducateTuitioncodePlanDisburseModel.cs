using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlanDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodePlanDisburseModel : AopObject
    {
        /// <summary>
        /// 订单支付人支付宝用户编号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// ISV订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求唯一编号，重复申请打款时不能相同。直连银行模式必填
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 学费码打款计划编号。优先使用plan_ids，如果是打款一个任务，传递一个编号即可
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 批量打款的打款任务编号列表。建议不超过3个
        /// </summary>
        [XmlArray("plan_ids")]
        [XmlArrayItem("string")]
        public List<string> PlanIds { get; set; }

        /// <summary>
        /// 2088401023137175
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单支付人支付宝用户编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
