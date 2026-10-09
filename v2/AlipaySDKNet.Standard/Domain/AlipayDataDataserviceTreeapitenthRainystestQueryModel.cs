using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceTreeapitenthRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceTreeapitenthRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_boolean")]
        public bool DemoBoolean { get; set; }
    }
}
