using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppDeliveryInfoQueryResponse.
    /// </summary>
    public class AlipayOpenAppDeliveryInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 履约信息列表
        /// </summary>
        [XmlArray("delivery_infos")]
        [XmlArrayItem("item_delivery_info_v_o")]
        public List<ItemDeliveryInfoVO> DeliveryInfos { get; set; }
    }
}
