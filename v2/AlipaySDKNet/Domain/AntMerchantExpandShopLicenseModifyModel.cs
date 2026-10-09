using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopLicenseModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopLicenseModifyModel : AopObject
    {
        /// <summary>
        /// 门店资质信息
        /// </summary>
        [XmlArray("audit_license_list")]
        [XmlArrayItem("shop_industry_license")]
        public List<ShopIndustryLicense> AuditLicenseList { get; set; }

        /// <summary>
        /// 商户角色id，表示门店店归属的商户角色。
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 蚂蚁店铺 id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户自己系统里的门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
