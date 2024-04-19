using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLeaseOfferQueryResponse.
    /// </summary>
    public class AlipayCommerceLeaseOfferQueryResponse : AopResponse
    {
        /// <summary>
        /// 租赁商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 计划sku维度报价详情
        /// </summary>
        [XmlArray("plan_offer_list")]
        [XmlArrayItem("lease_plan_offer_d_t_o")]
        public List<LeasePlanOfferDTO> PlanOfferList { get; set; }
    }
}
