using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitbudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelBenefitbudgetQueryModel : AopObject
    {
        /// <summary>
        /// 权益预算id列表
        /// </summary>
        [XmlArray("benefit_ids")]
        [XmlArrayItem("string")]
        public List<string> BenefitIds { get; set; }
    }
}
