using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotReceiptDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceIotReceiptDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 电子小票详情信息
        /// </summary>
        [XmlElement("data")]
        public ReceiptDetailInfo Data { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 返回子码
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [XmlElement("ret_message")]
        public string RetMessage { get; set; }

        /// <summary>
        /// 返回子消息
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// 调用是否成功(true/false)
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
