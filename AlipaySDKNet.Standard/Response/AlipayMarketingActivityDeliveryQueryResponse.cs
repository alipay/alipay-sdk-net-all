using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放信息列表
        /// </summary>
        [XmlArray("delivery_info_list")]
        [XmlArrayItem("promo_delivery_info")]
        public List<PromoDeliveryInfo> DeliveryInfoList { get; set; }
    }
}
