using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspOrguserCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspOrguserCreateResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 机构人员添加出参
        /// </summary>
        [XmlElement("data")]
        public IotIdentityOrgUserSaveApiResponse Data { get; set; }

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
