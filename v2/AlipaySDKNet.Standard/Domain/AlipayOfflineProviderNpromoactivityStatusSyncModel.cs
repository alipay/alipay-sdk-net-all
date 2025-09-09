using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpromoactivityStatusSyncModel : AopObject
    {
        /// <summary>
        /// 子活动推进业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 提前推进附言
        /// </summary>
        [XmlElement("in_advance_ps")]
        public string InAdvancePs { get; set; }

        /// <summary>
        /// 提前推进原因编码
        /// </summary>
        [XmlElement("in_advance_reason_code")]
        public string InAdvanceReasonCode { get; set; }

        /// <summary>
        /// 操作类型，用于区分正常按期推进活动还是提前推进活动。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 子活动的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户单期子活动的id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }
    }
}
