using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAppMergeConfirmResponse.
    /// </summary>
    public class AlipayFundTransAppMergeConfirmResponse : AopResponse
    {
        /// <summary>
        /// 合并付款单据号
        /// </summary>
        [XmlElement("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 转账结果列表。会列出该笔合并支付中所有的明细转账结果、状态基础信息。如果需要详情信息，请再请求单笔查询接口进行查询。
        /// </summary>
        [XmlArray("trans_order_results")]
        [XmlArrayItem("trans_order_result")]
        public List<TransOrderResult> TransOrderResults { get; set; }
    }
}
