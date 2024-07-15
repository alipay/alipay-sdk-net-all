using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdComplextypeRainysQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdComplextypeRainysQueryModel : AopObject
    {
        /// <summary>
        /// 引用同迭代的复杂类型
        /// </summary>
        [XmlElement("references_test_a")]
        public RainyComplexTypesTheSecond ReferencesTestA { get; set; }
    }
}
