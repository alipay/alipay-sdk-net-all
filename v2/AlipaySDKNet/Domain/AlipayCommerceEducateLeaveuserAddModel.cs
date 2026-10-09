using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateLeaveuserAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateLeaveuserAddModel : AopObject
    {
        /// <summary>
        /// 请假结束时间，格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 请假人花名册id
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }

        /// <summary>
        /// 请假开始时间，格式yyyy-MM-dd HH:mm
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
