using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollBaseInfo : AopObject
    {
        /// <summary>
        /// 报名时间。 系统处理创建报名调用的时间。
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 活动报名ID。 创建报名时返回的 enroll_id。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 创建报名的目标活动方案ID。
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 报名状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 报名状态说明信息。 当审核不通过时（status = REJECTED），非空。
        /// </summary>
        [XmlElement("status_description")]
        public string StatusDescription { get; set; }
    }
}
