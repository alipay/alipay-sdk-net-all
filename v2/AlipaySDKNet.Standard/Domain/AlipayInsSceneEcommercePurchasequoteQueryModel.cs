using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchasequoteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePurchasequoteQueryModel : AopObject
    {
        /// <summary>
        /// 商品信息 订购主体为商品时必传
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 报价范围  ALL_INSURE_PLAN : 对所有保障方案报价 SELETED_INSURE_PLAN : 只对已选方案报价 NONE : 无需报价
        /// </summary>
        [XmlElement("quote_scope")]
        public string QuoteScope { get; set; }

        /// <summary>
        /// 订购主体类型 PURCHASE_USER : 订购人(即商家) ECOM_ITEM : 商品
        /// </summary>
        [XmlElement("related_subject_type")]
        public string RelatedSubjectType { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
