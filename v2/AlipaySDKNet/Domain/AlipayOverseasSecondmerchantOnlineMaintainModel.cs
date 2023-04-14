using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasSecondmerchantOnlineMaintainModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasSecondmerchantOnlineMaintainModel : AopObject
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
        /// 二级商户地址
        /// </summary>
        [XmlElement("register_address")]
        public string RegisterAddress { get; set; }

        /// <summary>
        /// 二级商户所在国家码
        /// </summary>
        [XmlElement("register_country")]
        public string RegisterCountry { get; set; }

        /// <summary>
        /// 公司注册号
        /// </summary>
        [XmlElement("registration_no")]
        public string RegistrationNo { get; set; }

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
        /// 法定代表人国籍
        /// </summary>
        [XmlElement("representative_nationality")]
        public string RepresentativeNationality { get; set; }

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
        /// 股东国籍
        /// </summary>
        [XmlElement("shareholder_nationality")]
        public string ShareholderNationality { get; set; }

        /// <summary>
        /// 线上二级商户网站信息
        /// </summary>
        [XmlArray("site_infos")]
        [XmlArrayItem("merchant_site_info")]
        public List<MerchantSiteInfo> SiteInfos { get; set; }
    }
}
