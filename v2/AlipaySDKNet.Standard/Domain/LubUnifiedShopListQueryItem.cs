using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LubUnifiedShopListQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class LubUnifiedShopListQueryItem : AopObject
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 营业执照信息
        /// </summary>
        [XmlElement("business_license_info")]
        public LubBusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contact_ways")]
        [XmlArrayItem("lub_contact_way_info")]
        public List<LubContactWayInfo> ContactWays { get; set; }

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
        public LubLegalPersonInfo LegalPersonInfo { get; set; }

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
        /// 资质类型
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
        /// 门店类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店地址信息
        /// </summary>
        [XmlElement("store_address_info")]
        public LubStoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店主键ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
