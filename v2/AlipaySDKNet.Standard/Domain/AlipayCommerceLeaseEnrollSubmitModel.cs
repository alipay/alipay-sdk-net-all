using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLeaseEnrollSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLeaseEnrollSubmitModel : AopObject
    {
        /// <summary>
        /// 租赁计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 租赁商品sku提报信息列表
        /// </summary>
        [XmlArray("sku_submit_list")]
        [XmlArrayItem("lease_sku_submit_d_t_o")]
        public List<LeaseSkuSubmitDTO> SkuSubmitList { get; set; }
    }
}
