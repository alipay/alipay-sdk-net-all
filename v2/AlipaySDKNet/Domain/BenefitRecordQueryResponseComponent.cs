using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRecordQueryResponseComponent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRecordQueryResponseComponent : AopObject
    {
        /// <summary>
        /// 权益流水查询内容
        /// </summary>
        [XmlElement("content")]
        public BenefitRecordQueryContent Content { get; set; }
    }
}
