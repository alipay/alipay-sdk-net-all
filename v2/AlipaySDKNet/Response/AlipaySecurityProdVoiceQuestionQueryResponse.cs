using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdVoiceQuestionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdVoiceQuestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 问题推荐结果
        /// </summary>
        [XmlElement("question_result")]
        public string QuestionResult { get; set; }
    }
}
