using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspOrguserDeleteResponse.
    /// </summary>
    public class AlipayOpenIotvspOrguserDeleteResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 入库事件id
        /// </summary>
        [XmlElement("data")]
        public IotIdentityOrgUserRemoveApiResponse Data { get; set; }

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
