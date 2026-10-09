using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileOutContractRoot Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileOutContractRoot : AopObject
    {
        /// <summary>
        /// 移动核销出参Body
        /// </summary>
        [XmlElement("body")]
        public ChinaMobileOutBody Body { get; set; }

        /// <summary>
        /// 移动核销出参Head
        /// </summary>
        [XmlElement("head")]
        public ChinaMobileHead Head { get; set; }
    }
}
