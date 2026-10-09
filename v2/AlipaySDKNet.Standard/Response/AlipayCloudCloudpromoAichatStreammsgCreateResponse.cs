using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatStreammsgCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatStreammsgCreateResponse : AopResponse
    {
        /// <summary>
        /// 答案内容
        /// </summary>
        [XmlElement("data")]
        public ChatData Data { get; set; }

        /// <summary>
        /// 答案类型
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }
    }
}
