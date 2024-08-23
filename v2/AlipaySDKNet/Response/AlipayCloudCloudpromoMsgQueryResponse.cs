using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMsgQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMsgQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("aichat_push_msgs")]
        [XmlArrayItem("aichat_push_msg_v_o")]
        public List<AichatPushMsgVO> AichatPushMsgs { get; set; }
    }
}
