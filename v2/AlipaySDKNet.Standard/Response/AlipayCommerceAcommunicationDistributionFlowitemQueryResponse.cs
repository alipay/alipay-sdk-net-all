using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowitemQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFlowitemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_info")]
        public FlowItemInfo ItemInfo { get; set; }
    }
}
