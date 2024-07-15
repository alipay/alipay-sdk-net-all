using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowitemBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFlowitemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品总数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("flow_item_info")]
        public List<FlowItemInfo> ItemList { get; set; }
    }
}
