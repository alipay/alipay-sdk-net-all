using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishPropertySimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPropertySimplifyInfo : AopObject
    {
        /// <summary>
        /// 属性明细
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 属性组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
