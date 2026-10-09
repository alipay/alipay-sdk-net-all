using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePreorderquoteRefreshModel : AopObject
    {
        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
