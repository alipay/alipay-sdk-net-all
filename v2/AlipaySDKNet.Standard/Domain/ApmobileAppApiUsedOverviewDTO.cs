using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppApiUsedOverviewDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppApiUsedOverviewDTO : AopObject
    {
        /// <summary>
        /// api信息名称
        /// </summary>
        [XmlElement("info_name")]
        public string InfoName { get; set; }

        /// <summary>
        /// api信息类型
        /// </summary>
        [XmlElement("info_type")]
        public string InfoType { get; set; }
    }
}
