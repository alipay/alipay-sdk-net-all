using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtEcmcoreDataarchivesCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtEcmcoreDataarchivesCreateResponse : AopResponse
    {
        /// <summary>
        /// 数据id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 反馈消息内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
