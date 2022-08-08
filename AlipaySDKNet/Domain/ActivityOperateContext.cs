using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityOperateContext Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityOperateContext : AopObject
    {
        /// <summary>
        /// 活动单品信息(仅操作类型为MODIFY时存在)
        /// </summary>
        [XmlElement("activity_goods_benefit")]
        public ActivityGoodsBenefit ActivityGoodsBenefit { get; set; }

        /// <summary>
        /// 变更后的活动状态，枚举：WAIT_AUDIT（审核中）/AUDIT_FAIL（审核拒绝）/AUDIT_SUCCESS（审核通过）/PAUSE（暂停)
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }
    }
}
