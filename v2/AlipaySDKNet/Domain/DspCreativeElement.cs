using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspCreativeElement Data Structure.
    /// </summary>
    [Serializable]
    public class DspCreativeElement : AopObject
    {
        /// <summary>
        /// 创意属性名
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 创意属性值
        /// </summary>
        [XmlArray("attr_value")]
        [XmlArrayItem("string")]
        public List<string> AttrValue { get; set; }
    }
}
