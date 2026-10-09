using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopIndustryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopIndustryModifyModel : AopObject
    {
        /// <summary>
        /// 行业信息，例如所属集团、特殊标签
        /// </summary>
        [XmlArray("industry_info")]
        [XmlArrayItem("merchant_shop_industry_info")]
        public List<MerchantShopIndustryInfo> IndustryInfo { get; set; }

        /// <summary>
        /// 商户角色id，表示门店归属的商户角色。
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 蚂蚁店铺 id，通过ant.merchant.expand.shop.create/ant.merchant.expand.shop.modify获取
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
