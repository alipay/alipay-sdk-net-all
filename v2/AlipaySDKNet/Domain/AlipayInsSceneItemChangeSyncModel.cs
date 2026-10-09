using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneItemChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneItemChangeSyncModel : AopObject
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("ecom_item_d_t_o")]
        public List<EcomItemDTO> ItemList { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 产品编码，标识某一类产品:SHX
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订购合约id
        /// </summary>
        [XmlElement("purchase_contract_id")]
        public string PurchaseContractId { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
