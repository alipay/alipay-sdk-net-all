using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceOnlinetestRainysQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceOnlinetestRainysQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesTheten DemoRef { get; set; }
    }
}
