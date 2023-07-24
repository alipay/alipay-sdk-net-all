using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLeaseEnrollGetResponse.
    /// </summary>
    public class AlipayCommerceLeaseEnrollGetResponse : AopResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 租赁商sku报价信息
        /// </summary>
        [XmlArray("sku_offer_list")]
        [XmlArrayItem("lease_sku_offer_d_t_o")]
        public List<LeaseSkuOfferDTO> SkuOfferList { get; set; }
    }
}
