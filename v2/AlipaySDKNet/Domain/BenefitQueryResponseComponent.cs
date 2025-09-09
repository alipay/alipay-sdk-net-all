using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitQueryResponseComponent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryResponseComponent : AopObject
    {
        /// <summary>
        /// 权益召回内容
        /// </summary>
        [XmlElement("content")]
        public BenefitQueryContent Content { get; set; }
    }
}
