using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestdcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestdcQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(1234567891011121314151617182)
        /// </summary>
        [XmlElement("e")]
        public bool E { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(111111111111)
        /// </summary>
        [XmlElement("g")]
        public AAAAAtest G { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("i")]
        [XmlArrayItem("string")]
        public List<string> I { get; set; }
    }
}
