using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopCreateModel : AopObject
    {
        /// <summary>
        /// 授权委托书图片osskey
        /// </summary>
        [XmlElement("authorization_letter")]
        public string AuthorizationLetter { get; set; }

        /// <summary>
        /// 品牌ID，填写品牌ID可免传法人身份证信息
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 营业执照信息
        /// </summary>
        [XmlElement("business_license_info")]
        public LucBusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("luc_contact_way_info")]
        public List<LucContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 法人身份证信息
        /// </summary>
        [XmlElement("legal_person_info")]
        public LucLegalPersonInfo LegalPersonInfo { get; set; }

        /// <summary>
        /// 许可证编码（资质证明-许可证编码）
        /// </summary>
        [XmlElement("qualification_business_license")]
        public string QualificationBusinessLicense { get; set; }

        /// <summary>
        /// 资质证明图片URL
        /// </summary>
        [XmlElement("qualification_certificates")]
        public string QualificationCertificates { get; set; }

        /// <summary>
        /// 证件有效期（资质证明-有效期），格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("qualification_expiration_date")]
        public string QualificationExpirationDate { get; set; }

        /// <summary>
        /// 资质类型: 营业执照-BUSINESS_LICENSE/ 食品卫生许可证-FOOD_SANITATION_LICENSE/ 卫生许可证-SANITATION_LICENSE
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }

        /// <summary>
        /// 门店类目编码
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 门店类目名称
        /// </summary>
        [XmlElement("shop_category_name")]
        public string ShopCategoryName { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店类型: PHYSICAL_STORE-线下门店 / CLOUD_STORE-线上云店
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店地址信息（线下门店必填）<a href="https://mdn.alipayobjects.com/moneycard_bizfmcg/afts/file/O4-hR75f0RQAAAAAR_AAAAgADe7SAQBr">获取省、市、区编码</a>
        /// </summary>
        [XmlElement("store_address_info")]
        public LucStoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 补充材料类型: LEASE_CONTRACT-租赁合同 / PROPERTY_CERTIFICATE-产权证明 / AUTHORIZATION_MATERIAL-授权材料
        /// </summary>
        [XmlElement("supplementary_material_type")]
        public string SupplementaryMaterialType { get; set; }

        /// <summary>
        /// 补充材料图片URL
        /// </summary>
        [XmlElement("supplementary_material_url")]
        public string SupplementaryMaterialUrl { get; set; }
    }
}
