using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedfollowupBadgeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedfollowupBadgeNotifyModel : AopObject
    {
        /// <summary>
        /// 动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// aq目标id
        /// </summary>
        [XmlElement("aq_pid")]
        public string AqPid { get; set; }

        /// <summary>
        /// 随访信息
        /// </summary>
        [XmlElement("issue_biz_info")]
        public string IssueBizInfo { get; set; }

        /// <summary>
        /// 随访载荷
        /// </summary>
        [XmlElement("issue_body")]
        public string IssueBody { get; set; }

        /// <summary>
        /// 外部业务ID
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
