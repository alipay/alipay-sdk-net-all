using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceBkcsplatformPushwindowresultQueryResponse.
    /// </summary>
    public class AlipayIserviceBkcsplatformPushwindowresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户输入的验证码
        /// </summary>
        [XmlElement("feedback_values")]
        public string FeedbackValues { get; set; }

        /// <summary>
        /// 方舟工作台服务号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 推屏唯一code
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }
    }
}
