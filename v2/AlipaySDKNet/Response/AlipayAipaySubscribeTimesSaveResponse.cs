using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipaySubscribeTimesSaveResponse.
    /// </summary>
    public class AlipayAipaySubscribeTimesSaveResponse : AopResponse
    {
        /// <summary>
        /// 计数是否成功
        /// </summary>
        [XmlElement("data")]
        public SubscribeCountTimeResponse Data { get; set; }

        /// <summary>
        /// 请求失败的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
