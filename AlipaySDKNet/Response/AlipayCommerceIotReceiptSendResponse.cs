using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotReceiptSendResponse.
    /// </summary>
    public class AlipayCommerceIotReceiptSendResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段，暂时不用
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 小票id
        /// </summary>
        [XmlElement("receipt_id")]
        public string ReceiptId { get; set; }

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
        /// 调用成功失败（true/false）
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
