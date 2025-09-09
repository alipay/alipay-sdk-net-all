using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceComplextestsecondRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceComplextestsecondRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 引用同迭代的复杂类型
        /// </summary>
        [XmlElement("tc_case_01")]
        public RainyComplexTypesTheFourth TcCase01 { get; set; }
    }
}
