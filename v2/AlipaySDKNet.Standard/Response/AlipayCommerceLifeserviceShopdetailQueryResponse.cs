using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权委托书图片osskey
        /// </summary>
        [XmlElement("authorization_letter")]
        public string AuthorizationLetter { get; set; }

        /// <summary>
        /// 授权委托书图片URL
        /// </summary>
        [XmlElement("authorization_letter_url")]
        public string AuthorizationLetterUrl { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 营业执照信息
        /// </summary>
        [XmlElement("business_license_info")]
        public LudBusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("lud_contact_way_info")]
        public List<LudContactWayInfo> ContactWays { get; set; }

        /// <summary>
        /// 创建时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 法人身份证信息
        /// </summary>
        [XmlElement("legal_person_info")]
        public LudLegalPersonInfo LegalPersonInfo { get; set; }

        /// <summary>
        /// MCC类目编码
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

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
        /// 资质类型: FOOD_BUSINESS_LICENSE-食品经营许可证 / OTHER_FOOD_BUSINESS_LICENSE-其他食品经营许可证
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }

        /// <summary>
        /// 门店类目编码路径
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 门店类目名称
        /// </summary>
        [XmlElement("shop_category_name")]
        public string ShopCategoryName { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

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
        /// 门店状态: INIT-初始化 / NORMAL-正常 / CANCEL-注销 / FREEZON-冻结 / PAUSED-暂停营业
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店地址信息
        /// </summary>
        [XmlElement("store_address_info")]
        public LudStoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店主键ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

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
