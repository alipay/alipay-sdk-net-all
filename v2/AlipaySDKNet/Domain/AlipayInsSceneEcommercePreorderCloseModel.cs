using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePreorderCloseModel : AopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 指定预下单列表，选填
        /// </summary>
        [XmlArray("pre_order_ids")]
        [XmlArrayItem("string")]
        public List<string> PreOrderIds { get; set; }
    }
}
