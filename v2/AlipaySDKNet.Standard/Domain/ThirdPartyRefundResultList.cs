using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdPartyRefundResultList Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdPartyRefundResultList : AopObject
    {
        /// <summary>
        /// 退款失败的原因,退款成功时为空
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 单笔订单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退款异常任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
