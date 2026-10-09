using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRobotHotquestionQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmRobotHotquestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 聊天窗配置的热门问题
        /// </summary>
        [XmlArray("questions")]
        [XmlArrayItem("question_info")]
        public List<QuestionInfo> Questions { get; set; }
    }
}
