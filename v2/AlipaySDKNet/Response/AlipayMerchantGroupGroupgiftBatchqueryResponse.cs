using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupgiftBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupgiftBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 入群有礼配置记录列表
        /// </summary>
        [XmlArray("join_gift_record_list")]
        [XmlArrayItem("multi_channel_join_gift_record_v_o")]
        public List<MultiChannelJoinGiftRecordVO> JoinGiftRecordList { get; set; }

        /// <summary>
        /// 入群有礼总条数。取值单位是"条"。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
