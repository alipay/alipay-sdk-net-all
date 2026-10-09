using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitActivity Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitActivity : AopObject
    {
        /// <summary>
        /// 群等权益的id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 入群有礼
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
