using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriceQuery Data Structure.
    /// </summary>
    [Serializable]
    public class PriceQuery : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 单位：元
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
