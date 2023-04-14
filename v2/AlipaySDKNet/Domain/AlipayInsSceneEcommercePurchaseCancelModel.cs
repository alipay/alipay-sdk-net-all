using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePurchaseCancelModel : AopObject
    {
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
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
