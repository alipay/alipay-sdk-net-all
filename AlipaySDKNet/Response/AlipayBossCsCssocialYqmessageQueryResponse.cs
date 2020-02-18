using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossCsCssocialYqmessageQueryResponse.
    /// </summary>
    public class AlipayBossCsCssocialYqmessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的舆情数据结果字符串。舆情数据及信息存放在JSON字符串中，如舆情的标题（title）、内容（content）等
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
