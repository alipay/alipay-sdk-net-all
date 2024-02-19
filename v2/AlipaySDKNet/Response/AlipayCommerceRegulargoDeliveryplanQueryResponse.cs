using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRegulargoDeliveryplanQueryResponse.
    /// </summary>
    public class AlipayCommerceRegulargoDeliveryplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 配送计划中的履约信息
        /// </summary>
        [XmlElement("fulfillment_info")]
        public DeliveryFulfillmentVO FulfillmentInfo { get; set; }

        /// <summary>
        /// 配送计划中的子单列表
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("delivery_sub_order_v_o")]
        public List<DeliverySubOrderVO> SubOrderList { get; set; }
    }
}
