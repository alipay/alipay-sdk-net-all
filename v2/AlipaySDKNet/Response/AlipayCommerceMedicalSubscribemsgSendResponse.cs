using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSubscribemsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalSubscribemsgSendResponse : AopResponse
    {
        /// <summary>
        /// 业务错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
