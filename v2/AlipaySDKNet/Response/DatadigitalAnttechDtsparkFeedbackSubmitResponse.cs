using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechDtsparkFeedbackSubmitResponse.
    /// </summary>
    public class DatadigitalAnttechDtsparkFeedbackSubmitResponse : AopResponse
    {
        /// <summary>
        /// 单次会话反馈结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
