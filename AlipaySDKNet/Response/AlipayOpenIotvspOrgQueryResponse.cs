using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspOrgQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspOrgQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 机构信息
        /// </summary>
        [XmlElement("data")]
        public IotIdentityOrgQueryApiResponse Data { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 响应是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
