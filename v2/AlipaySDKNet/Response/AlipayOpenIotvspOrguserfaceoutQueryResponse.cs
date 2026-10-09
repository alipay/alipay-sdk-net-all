using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspOrguserfaceoutQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspOrguserfaceoutQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 事件响应
        /// </summary>
        [XmlElement("data")]
        public IotIdentityFaceOutEventApiResponse Data { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
