using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeDeductMergePayResponse.
    /// </summary>
    public class AlipayTradeDeductMergePayResponse : AopResponse
    {
        /// <summary>
        /// 用户userId，2088开头
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 子单明细
        /// </summary>
        [XmlArray("order_detail_results")]
        [XmlArrayItem("sub_order_result")]
        public List<SubOrderResult> OrderDetailResults { get; set; }

        /// <summary>
        /// 外部合并请求号
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }
    }
}
