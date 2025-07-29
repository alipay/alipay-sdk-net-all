using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeSchemaapithirtyfouthRainstestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeSchemaapithirtyfouthRainstestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据无需关注
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 测试数据无需关注
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
