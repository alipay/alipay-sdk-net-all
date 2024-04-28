using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDdtJhjtestCreateResponse.
    /// </summary>
    public class AlipayDataDdtJhjtestCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ot_a")]
        public string OtA { get; set; }

        /// <summary>
        /// 文档测试
        /// </summary>
        [XmlElement("output_a")]
        public string OutputA { get; set; }

        /// <summary>
        /// 文档测试
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// B下主键
        /// </summary>
        [XmlElement("user_id_openid")]
        public string UserIdOpenid { get; set; }
    }
}
