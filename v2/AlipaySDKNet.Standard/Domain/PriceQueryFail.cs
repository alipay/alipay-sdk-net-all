using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriceQueryFail Data Structure.
    /// </summary>
    [Serializable]
    public class PriceQueryFail : AopObject
    {
        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
