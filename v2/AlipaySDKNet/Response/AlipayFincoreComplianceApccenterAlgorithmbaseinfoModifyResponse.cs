using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceApccenterAlgorithmbaseinfoModifyResponse.
    /// </summary>
    public class AlipayFincoreComplianceApccenterAlgorithmbaseinfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 平台算法唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_code")]
        public string PlatformAlgorithmCode { get; set; }

        /// <summary>
        /// 平台算法来源
        /// </summary>
        [XmlElement("platform_algorithm_source")]
        public string PlatformAlgorithmSource { get; set; }
    }
}
