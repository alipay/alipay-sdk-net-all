using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DataInfo : AopObject
    {
        /// <summary>
        /// 后续安排说明
        /// </summary>
        [XmlElement("arrangement")]
        public string Arrangement { get; set; }

        /// <summary>
        /// 商户联系用户的时间
        /// </summary>
        [XmlElement("contact_time")]
        public string ContactTime { get; set; }

        /// <summary>
        /// 失败详细描述
        /// </summary>
        [XmlElement("fail_detail")]
        public string FailDetail { get; set; }

        /// <summary>
        /// 失败原因编码
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 后续跟进计划
        /// </summary>
        [XmlElement("follow_up_plan")]
        public string FollowUpPlan { get; set; }

        /// <summary>
        /// 拒绝详细描述
        /// </summary>
        [XmlElement("reject_detail")]
        public string RejectDetail { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
