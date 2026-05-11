using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpIndustryModelClasses Data Structure.
    /// </summary>
    [Serializable]
    public class EpIndustryModelClasses : AopObject
    {
        /// <summary>
        /// 所属行业
        /// </summary>
        [XmlElement("industry_desc")]
        public string IndustryDesc { get; set; }
    }
}
