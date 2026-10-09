using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountInvitedConvertSyncResponse.
    /// </summary>
    public class AlipayUserAccountInvitedConvertSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 本次处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
