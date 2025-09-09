using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAssistantGuessquestionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAssistantGuessquestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        [XmlElement("questions")]
        public GuessQuestion Questions { get; set; }
    }
}
