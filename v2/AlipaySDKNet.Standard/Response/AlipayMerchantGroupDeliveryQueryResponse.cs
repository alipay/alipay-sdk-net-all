using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广计划详情
        /// </summary>
        [XmlElement("delivery_detail")]
        public GroupDeliveryDetailVO DeliveryDetail { get; set; }
    }
}
