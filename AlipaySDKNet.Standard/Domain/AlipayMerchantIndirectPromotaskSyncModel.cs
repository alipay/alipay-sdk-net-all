using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectPromotaskSyncModel : AopObject
    {
        /// <summary>
        /// 业务场景编码，接入时参考业务接入文档由支付宝侧分配。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝侧定义的商户组唯一编号，作为同一商户主体下多个smid的唯一商户编号。
        /// </summary>
        [XmlElement("group_mid")]
        public string GroupMid { get; set; }

        /// <summary>
        /// 服务商渠道2088
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }

        /// <summary>
        /// 任务英文编号
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务实例ID，领取任务后有效
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态，枚举值： 1. FINISH，结束任务(任务已完成) 2. UN_FINISH，任务结束((任务未完成))
        /// </summary>
        [XmlElement("task_state")]
        public string TaskState { get; set; }
    }
}
