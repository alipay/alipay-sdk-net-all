using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMessageMatcherSendResponse.
    /// </summary>
    public class AlipayMobileStdPublicMessageMatcherSendResponse : AopResponse
    {
        /// <summary>
        /// 对应toUserId，标准Alipay UserId
        /// </summary>
        [XmlElement("to_alipay_user_id")]
        public string ToAlipayUserId { get; set; }

        /// <summary>
        /// 消息接收人的用户ID，值取的openId
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
