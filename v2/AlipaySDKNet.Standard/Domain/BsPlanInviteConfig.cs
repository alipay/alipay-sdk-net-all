using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsPlanInviteConfig Data Structure.
    /// </summary>
    [Serializable]
    public class BsPlanInviteConfig : AopObject
    {
        /// <summary>
        /// 计划报名、邀约结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 计划报名、邀约开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
