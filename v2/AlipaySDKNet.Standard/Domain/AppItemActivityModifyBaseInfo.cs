using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemActivityModifyBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemActivityModifyBaseInfo : AopObject
    {
        /// <summary>
        /// 活动id 来源：来自创建接口返回的activity_id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }
    }
}
