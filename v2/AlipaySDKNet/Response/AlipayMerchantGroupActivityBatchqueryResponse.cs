using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupActivityBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 顶部运营位记录列表
        /// </summary>
        [XmlArray("activity_record_list")]
        [XmlArrayItem("group_activity_record_v_o")]
        public List<GroupActivityRecordVO> ActivityRecordList { get; set; }

        /// <summary>
        /// 商家配置商家群活动总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
