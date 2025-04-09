using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistanceMarkupRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistanceMarkupRuleDTO : AopObject
    {
        /// <summary>
        /// 超限距离，单位：km
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 加价金额，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
