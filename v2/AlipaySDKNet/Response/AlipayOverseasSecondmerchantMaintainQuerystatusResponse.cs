using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasSecondmerchantMaintainQuerystatusResponse.
    /// </summary>
    public class AlipayOverseasSecondmerchantMaintainQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_no")]
        public string ContactNo { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [XmlElement("cs_email")]
        public string CsEmail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("cs_no")]
        public string CsNo { get; set; }

        /// <summary>
        /// 店铺外景照URL地址
        /// </summary>
        [XmlElement("external_storefront_photo")]
        public string ExternalStorefrontPhoto { get; set; }

        /// <summary>
        /// 店铺内景照URL地址
        /// </summary>
        [XmlElement("internal_store_photo")]
        public string InternalStorePhoto { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 二级商户的支付场景，包括INSTORE_PAYMENT 和 ONLINE_PAYMENT
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [XmlElement("register_address")]
        public string RegisterAddress { get; set; }

        /// <summary>
        /// 商户注册国家
        /// </summary>
        [XmlElement("register_country")]
        public string RegisterCountry { get; set; }

        /// <summary>
        /// 公司注册号
        /// </summary>
        [XmlElement("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// 二级商户报备失败原因描述
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 个人ID
        /// </summary>
        [XmlElement("representative_id")]
        public string RepresentativeId { get; set; }

        /// <summary>
        /// 个人姓名
        /// </summary>
        [XmlElement("representative_name")]
        public string RepresentativeName { get; set; }

        /// <summary>
        /// 二级商户ID
        /// </summary>
        [XmlElement("secondary_merchant_id")]
        public string SecondaryMerchantId { get; set; }

        /// <summary>
        /// 二级商户行业类型
        /// </summary>
        [XmlElement("secondary_merchant_industry")]
        public string SecondaryMerchantIndustry { get; set; }

        /// <summary>
        /// 二级商户名称
        /// </summary>
        [XmlElement("secondary_merchant_name")]
        public string SecondaryMerchantName { get; set; }

        /// <summary>
        /// 二级商户类型
        /// </summary>
        [XmlElement("secondary_merchant_type")]
        public string SecondaryMerchantType { get; set; }

        /// <summary>
        /// 商户结算卡号
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }

        /// <summary>
        /// 股东ID
        /// </summary>
        [XmlElement("shareholder_id")]
        public string ShareholderId { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [XmlElement("shareholder_name")]
        public string ShareholderName { get; set; }

        /// <summary>
        /// 线上二级商户网站信息
        /// </summary>
        [XmlArray("site_infos")]
        [XmlArrayItem("merchant_site_info")]
        public List<MerchantSiteInfo> SiteInfos { get; set; }

        /// <summary>
        /// 二级商户报备审核结果， SUCCESS: The latest registration or update succeeds. UNDER_REVIEW: The latest registration is under review. MODIFICATION_REVIEW: The latest update is under review. FAILED: The latest registration or update is failed and the reject_reason field will be returned.
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 店铺地址信息
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 店铺所在国家，两位国家码
        /// </summary>
        [XmlElement("store_country")]
        public string StoreCountry { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店铺行业类型
        /// </summary>
        [XmlElement("store_industry")]
        public string StoreIndustry { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// Store status. The value can be one of the following items: ARCHIVED: The store is archived, so that the store information cannot be viewed. ACTIVATED: The store is registered successfully. INACTIVATE: The store is not registered.
        /// </summary>
        [XmlElement("store_status")]
        public string StoreStatus { get; set; }
    }
}
