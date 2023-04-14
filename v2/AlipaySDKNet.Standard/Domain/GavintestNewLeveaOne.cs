using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GavintestNewLeveaOne Data Structure.
    /// </summary>
    [Serializable]
    public class GavintestNewLeveaOne : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("boolen")]
        public bool Boolen { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("ces")]
        [XmlArrayItem("number")]
        public List<long> Ces { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("str")]
        [XmlArrayItem("string")]
        public List<string> Str { get; set; }
    }
}
