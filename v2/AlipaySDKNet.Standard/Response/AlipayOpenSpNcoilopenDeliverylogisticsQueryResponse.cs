using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenDeliverylogisticsQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenDeliverylogisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("delivery_infos")]
        [XmlArrayItem("delivery_logistics")]
        public List<DeliveryLogistics> DeliveryInfos { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
