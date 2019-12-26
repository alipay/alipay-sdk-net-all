using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportMessageSendResponse.
    /// </summary>
    public class AlipayCommerceTransportMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 失败的支付宝用户id列表。
        /// </summary>
        [XmlElement("failed_user_ids")]
        public string FailedUserIds { get; set; }
    }
}
