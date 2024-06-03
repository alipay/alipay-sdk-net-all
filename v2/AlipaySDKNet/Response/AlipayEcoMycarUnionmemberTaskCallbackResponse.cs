using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarUnionmemberTaskCallbackResponse.
    /// </summary>
    public class AlipayEcoMycarUnionmemberTaskCallbackResponse : AopResponse
    {
        /// <summary>
        /// 回传处理完成后实际的发奖状态
        /// </summary>
        [XmlElement("award_status")]
        public string AwardStatus { get; set; }

        /// <summary>
        /// 回传处理成功后实际的任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
