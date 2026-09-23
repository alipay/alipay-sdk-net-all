using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceCpaNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceCpaNotifyModel : AopObject
    {
        /// <summary>
        /// 该值是CPA任务投放全链路进行唯一归因的标记。
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// CPA子任务ID
        /// </summary>
        [XmlElement("sub_task_id")]
        public string SubTaskId { get; set; }

        /// <summary>
        /// CPA任务的完成节点，比如曝光，到访，点击等。
        /// </summary>
        [XmlElement("task_node")]
        public string TaskNode { get; set; }

        /// <summary>
        /// 任务完成的时间。
        /// </summary>
        [XmlElement("task_node_finished")]
        public string TaskNodeFinished { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
