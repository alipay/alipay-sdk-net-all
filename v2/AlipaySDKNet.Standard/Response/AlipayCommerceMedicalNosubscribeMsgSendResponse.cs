using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalNosubscribeMsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalNosubscribeMsgSendResponse : AopResponse
    {
        /// <summary>
        /// 支付宝消息id列表
        /// </summary>
        [XmlArray("msg_id_list")]
        [XmlArrayItem("string")]
        public List<string> MsgIdList { get; set; }

        /// <summary>
        /// 外部商户消息唯一标识
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }
    }
}
