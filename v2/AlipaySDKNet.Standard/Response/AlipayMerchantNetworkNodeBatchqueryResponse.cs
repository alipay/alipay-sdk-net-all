using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantNetworkNodeBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantNetworkNodeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 节点列表
        /// </summary>
        [XmlArray("tree_node_info_list")]
        [XmlArrayItem("tree_node_info")]
        public List<TreeNodeInfo> TreeNodeInfoList { get; set; }
    }
}
