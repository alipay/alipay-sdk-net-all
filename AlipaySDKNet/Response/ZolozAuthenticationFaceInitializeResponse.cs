using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationFaceInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationFaceInitializeResponse : AopResponse
    {
        /// <summary>
        /// 由客户端解析的非明文字符串数据
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// zim唯一标识
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
