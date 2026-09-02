using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceUnifiedshopModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceUnifiedshopModifyModel : AopObject
    {
        /// <summary>
        /// 授权委托书图片osskey
        /// </summary>
        [XmlElement("authorization_letter")]
        public string AuthorizationLetter { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 营业执照信息，可选重传，不传则保留原值
        /// </summary>
        [XmlElement("business_license_info")]
        public LumBusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("lum_contact_way_info")]
        public List<LumContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 门店副本ID，update_from=COPY时必填
        /// </summary>
        [XmlElement("copy_id")]
        public string CopyId { get; set; }

        /// <summary>
        /// 法人身份证信息，与business_license_info同时传或同时不传
        /// </summary>
        [XmlElement("legal_person_info")]
        public LumLegalPersonInfo LegalPersonInfo { get; set; }

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
        /// 证件有效期（资质证明-有效期），格式yyyy-MM-dd，空表示长期有效
        /// </summary>
        [XmlElement("qualification_expiration_date")]
        public string QualificationExpirationDate { get; set; }

        /// <summary>
        /// 资质类型：FOOD_BUSINESS_LICENSE-食品经营许可证 / OTHER_FOOD_BUSINESS_LICENSE-其他食品经营许可证
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }

        /// <summary>
        /// 门店类目编码路径，如A0002/B0013/C0025
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
        /// 门店地址信息（线下门店修改时必填）<a href="https://mdn.alipayobjects.com/moneycard_bizfmcg/afts/file/O4-hR75f0RQAAAAAR_AAAAgADe7SAQBr">获取省、市、区编码</a>
        /// </summary>
        [XmlElement("store_address_info")]
        public LumStoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店主键ID（正本表ID）
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 补充材料类型：LEASE_CONTRACT-租赁合同 / PROPERTY_CERTIFICATE-产权证明 / AUTHORIZATION_MATERIAL-授权材料
        /// </summary>
        [XmlElement("supplementary_material_type")]
        public string SupplementaryMaterialType { get; set; }

        /// <summary>
        /// 补充材料图片URL
        /// </summary>
        [XmlElement("supplementary_material_url")]
        public string SupplementaryMaterialUrl { get; set; }

        /// <summary>
        /// 更新来源：ORIGINAL-基于正本更新 / COPY-基于副本更新
        /// </summary>
        [XmlElement("update_from")]
        public string UpdateFrom { get; set; }
    }
}
