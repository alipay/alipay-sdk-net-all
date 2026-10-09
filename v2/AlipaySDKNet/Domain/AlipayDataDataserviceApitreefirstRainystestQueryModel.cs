using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceApitreefirstRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceApitreefirstRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 无参数
        /// </summary>
        [XmlElement("demo_case")]
        public RainyComplexTypesTheFifteen DemoCase { get; set; }
    }
}
