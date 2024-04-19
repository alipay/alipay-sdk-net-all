using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanTuringtagQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanTuringtagQueryResponse : AopResponse
    {
        /// <summary>
        /// 节点列表
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("crowd_operation_node")]
        public List<CrowdOperationNode> NodeList { get; set; }
    }
}
