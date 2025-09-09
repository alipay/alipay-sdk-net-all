using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LegacyPreFilterExtraValueDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LegacyPreFilterExtraValueDetail : AopObject
    {
        /// <summary>
        /// 筛选值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
