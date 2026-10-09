using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitActionResponseComponent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitActionResponseComponent : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public BenefitActionContent Content { get; set; }
    }
}
