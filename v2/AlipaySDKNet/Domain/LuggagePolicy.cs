using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LuggagePolicy Data Structure.
    /// </summary>
    [Serializable]
    public class LuggagePolicy : AopObject
    {
        /// <summary>
        /// 航段编号
        /// </summary>
        [XmlElement("airline_no")]
        public string AirlineNo { get; set; }

        /// <summary>
        /// 行李手提/托运的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 1：托运 2：手提
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
