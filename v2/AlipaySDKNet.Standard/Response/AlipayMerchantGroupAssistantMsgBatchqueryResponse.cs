using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantMsgBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商家发送的小助手定向消息记录列表
        /// </summary>
        [XmlArray("msg_record_list")]
        [XmlArrayItem("assistant_msg_record_v_o")]
        public List<AssistantMsgRecordVO> MsgRecordList { get; set; }

        /// <summary>
        /// 商家配置小助手定向消息总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
