using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAutoreplyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("group_msg_autoreply_list")]
        [XmlArrayItem("group_msg_autoreply_record_v_o")]
        public List<GroupMsgAutoreplyRecordVO> GroupMsgAutoreplyList { get; set; }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大展示50条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 自动回复记录总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
