using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceApccenterAlgorithmarchiveDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceApccenterAlgorithmarchiveDetectModel : AopObject
    {
        /// <summary>
        /// 平台算法唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_code")]
        public string PlatformAlgorithmCode { get; set; }

        /// <summary>
        /// 平台算法最新迭代唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_last_iteration_code")]
        public string PlatformAlgorithmLastIterationCode { get; set; }

        /// <summary>
        /// 平台算法来源
        /// </summary>
        [XmlElement("platform_algorithm_source")]
        public string PlatformAlgorithmSource { get; set; }
    }
}
