using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasOperationdataUploadResponse.
    /// </summary>
    public class AlipayOpenIotbpaasOperationdataUploadResponse : AopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("flag")]
        public bool Flag { get; set; }

        /// <summary>
        /// 业务结果信息，用于错误排查
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
