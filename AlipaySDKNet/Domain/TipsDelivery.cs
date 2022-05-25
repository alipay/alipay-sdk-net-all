using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TipsDelivery Data Structure.
    /// </summary>
    [Serializable]
    public class TipsDelivery : AopObject
    {
        /// <summary>
        /// 收藏引导文案内容
        /// </summary>
        [XmlElement("delivery_content")]
        public string DeliveryContent { get; set; }

        /// <summary>
        /// 收藏引导投放活动ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 收藏引导投放活动的名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 文案审核驳回理由，仅AUDIT_REJECTED生效
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 匹配类型：GLOBAL为全局生效，TARGETURL为目标页面生效，需配置相应页面地址match_url。
        /// </summary>
        [XmlElement("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// 目标页面地址
        /// </summary>
        [XmlElement("match_url")]
        public string MatchUrl { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态。 枚举值： INIT: 初始化；AUDITING: 审核中；AUDIT_REJECTED:审核驳回；WORKING: 生效中；PUASE: 暂停；FINISHED 已结束；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
