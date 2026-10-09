using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ForwardFeedbackOrderRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ForwardFeedbackOrderRequest : AopObject
    {
        /// <summary>
        /// 反馈说明
        /// </summary>
        [XmlElement("feedback_desc")]
        public string FeedbackDesc { get; set; }

        /// <summary>
        /// 反馈类型
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }

        /// <summary>
        /// 机构工单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 客权工单ID
        /// </summary>
        [XmlElement("self_order_id")]
        public string SelfOrderId { get; set; }
    }
}
