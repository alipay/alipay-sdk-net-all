using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupActivityStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupActivityStatusModifyModel : AopObject
    {
        /// <summary>
        /// 商家群活动id
        /// </summary>
        [XmlElement("group_activity_id")]
        public string GroupActivityId { get; set; }

        /// <summary>
        /// 顶部运营位更新状态 1、STOPPED(提前结束)，提前结束操作只能在上线状态VALID才能操作             状态流转如下：VALID(生效)->STOPPED(提前结束)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
