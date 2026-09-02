using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolutionRiskConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolutionRiskConsultModel : AopObject
    {
        /// <summary>
        /// 标识唯一的解决方案
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
