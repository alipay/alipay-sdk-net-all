using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchemaapithirtyfouthRainstestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchemaapithirtyfouthRainstestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据无需关注
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 测试数据，需关注
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 测试数据无需关注
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
