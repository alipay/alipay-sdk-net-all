using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAreaplatformMsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalAreaplatformMsgSendResponse : AopResponse
    {
        /// <summary>
        /// 业务错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 消息id列表
        /// </summary>
        [XmlArray("msg_id_list")]
        [XmlArrayItem("string")]
        public List<string> MsgIdList { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
