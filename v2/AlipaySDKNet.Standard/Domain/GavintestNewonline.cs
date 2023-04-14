using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GavintestNewonline Data Structure.
    /// </summary>
    [Serializable]
    public class GavintestNewonline : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("dem")]
        [XmlArrayItem("string")]
        public List<string> Dem { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("string")]
        public GavintestNewLeveaOne String { get; set; }
    }
}
