using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchematwentyseventhRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchematwentyseventhRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_num")]
        public long DemoNum { get; set; }
    }
}
