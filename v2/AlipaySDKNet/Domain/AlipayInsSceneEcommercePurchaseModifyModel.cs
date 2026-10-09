using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePurchaseModifyModel : AopObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 是否需要核验保障方案定价
        /// </summary>
        [XmlElement("check_quote")]
        public bool CheckQuote { get; set; }

        /// <summary>
        /// 指定生效时间，可选,限时订购时有效
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 指定失效时间，可选,限时订购时有效
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品:订购主体为商品时必传
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }

        /// <summary>
        /// 订购选定的保障方案
        /// </summary>
        [XmlElement("purchase_insure_plan_dto")]
        public PurchaseInsurePlanDTO PurchaseInsurePlanDto { get; set; }

        /// <summary>
        /// 是否自动续订:限时/限量订购时有效
        /// </summary>
        [XmlElement("renew")]
        public bool Renew { get; set; }

        /// <summary>
        /// 自动续订期限，若需要限时，则必传
        /// </summary>
        [XmlElement("renew_period")]
        public InsPeriodDTO RenewPeriod { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 订购数量，可选,按量订购时有效
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 客户端渠道:ios / android / pc / wx_applet(微信小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
