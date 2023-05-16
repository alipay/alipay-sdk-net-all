using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonGrouporderQueryResponse.
    /// </summary>
    public class AlipayInsSceneCommonGrouporderQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次信息列表
        /// </summary>
        [XmlArray("batch_info_list")]
        [XmlArrayItem("ins_group_order_batch_digest")]
        public List<InsGroupOrderBatchDigest> BatchInfoList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 子单数量
        /// </summary>
        [XmlElement("sub_order_count")]
        public long SubOrderCount { get; set; }

        /// <summary>
        /// 总保费
        /// </summary>
        [XmlElement("summary_order_premium")]
        public long SummaryOrderPremium { get; set; }
    }
}
