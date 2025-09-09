using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyShopQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 该门店（收货地）下物料数量
        /// </summary>
        [XmlElement("materials_num")]
        public long MaterialsNum { get; set; }

        /// <summary>
        /// 门店的物流信息
        /// </summary>
        [XmlArray("shop_delivery_info")]
        [XmlArrayItem("shop_delivery_info")]
        public List<ShopDeliveryInfo> ShopDeliveryInfo { get; set; }
    }
}
