using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemActivityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemActivityBaseInfo : AopObject
    {
        /// <summary>
        /// 活动名称。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }
    }
}
