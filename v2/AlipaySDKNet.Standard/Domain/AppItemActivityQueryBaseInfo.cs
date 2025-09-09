using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemActivityQueryBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemActivityQueryBaseInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }
    }
}
