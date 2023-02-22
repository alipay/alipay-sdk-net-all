using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlArray("select_tag_values")]
        [XmlArrayItem("crowd_select_tag_values_open_request")]
        public List<CrowdSelectTagValuesOpenRequest> SelectTagValues { get; set; }
    }
}
