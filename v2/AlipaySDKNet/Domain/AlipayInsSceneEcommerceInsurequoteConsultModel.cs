using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsurequoteConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceInsurequoteConsultModel : AopObject
    {
        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 保障期限
        /// </summary>
        [XmlElement("ins_period")]
        public InsPeriodDTO InsPeriod { get; set; }

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
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 客户端渠道:ios / android / pc / wx_applet / alipay_applet
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
