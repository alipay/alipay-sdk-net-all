using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRight Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRight : AopObject
    {
        /// <summary>
        /// 权益展示信息
        /// </summary>
        [XmlElement("display_info")]
        public BenefitDisplayInfoResponse DisplayInfo { get; set; }
    }
}
