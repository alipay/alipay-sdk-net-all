using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskTakeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectPromotaskTakeModel : AopObject
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
        /// 服务器渠道2088
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }

        /// <summary>
        /// 任务领取时间
        /// </summary>
        [XmlElement("take_time")]
        public string TakeTime { get; set; }

        /// <summary>
        /// 支付宝侧返回的任务目标值，数值类型
        /// </summary>
        [XmlElement("target_value")]
        public long TargetValue { get; set; }

        /// <summary>
        /// 任务英文编号
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务实例ID，领取任务后有效
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
