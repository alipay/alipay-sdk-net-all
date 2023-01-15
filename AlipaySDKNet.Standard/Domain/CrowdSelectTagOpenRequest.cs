using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSelectTagOpenRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSelectTagOpenRequest : AopObject
    {
        /// <summary>
        /// 圈选标签值
        /// </summary>
        [XmlElement("select_tag_values")]
        public CrowdSelectTagValuesOpenRequest SelectTagValues { get; set; }
    }
}
