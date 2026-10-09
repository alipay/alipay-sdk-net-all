using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeMergeCreateResponse.
    /// </summary>
    public class AlipayTradeMergeCreateResponse : AopResponse
    {
        /// <summary>
        /// 合并交易号，用于后续唤起收银台使用，当所有子订单都下单成功后返回，2小时后失效。失效后需重新发起合并下单请求。
        /// </summary>
        [XmlElement("merge_no")]
        public string MergeNo { get; set; }

        /// <summary>
        /// 合并子订单中所有订单的创建结果
        /// </summary>
        [XmlArray("order_detail_results")]
        [XmlArrayItem("sub_order_result")]
        public List<SubOrderResult> OrderDetailResults { get; set; }

        /// <summary>
        /// 外部合并单号
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }
    }
}
