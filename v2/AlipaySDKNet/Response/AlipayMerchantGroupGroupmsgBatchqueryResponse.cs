using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupmsgBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商家群内群发消息发送记录列表
        /// </summary>
        [XmlArray("msg_record_list")]
        [XmlArrayItem("group_msg_record_v_o")]
        public List<GroupMsgRecordVO> MsgRecordList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示记录条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家群群发消息记录总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
