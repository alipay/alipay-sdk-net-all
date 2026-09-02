using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchemapiseventhirdRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchemapiseventhirdRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesTheten DemoRef { get; set; }
    }
}
