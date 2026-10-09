using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseFollowupCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseFollowupCancelModel : AopObject
    {
        /// <summary>
        /// 客户业务单号，任务定位键。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 取消原因，仅作记录，不影响状态流转；平台统一按客户主动取消处理。
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
