using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantBaseInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantBaseInfoResponse : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("corp_address")]
        public string CorpAddress { get; set; }

        /// <summary>
        /// XX企业
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 企业性质编码
        /// </summary>
        [XmlElement("corp_nature_code")]
        public string CorpNatureCode { get; set; }

        /// <summary>
        /// 公司类型
        /// </summary>
        [XmlElement("corp_type")]
        public string CorpType { get; set; }

        /// <summary>
        /// 金额单位
        /// </summary>
        [XmlElement("currency_name")]
        public string CurrencyName { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("district_encode")]
        public string DistrictEncode { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("established_date")]
        public string EstablishedDate { get; set; }

        /// <summary>
        /// 行业代码
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 是否最新
        /// </summary>
        [XmlElement("is_latest")]
        public long IsLatest { get; set; }

        /// <summary>
        /// 发照日期
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 法人
        /// </summary>
        [XmlElement("legal_representative")]
        public string LegalRepresentative { get; set; }

        /// <summary>
        /// 法人id
        /// </summary>
        [XmlElement("legal_representative_id")]
        public string LegalRepresentativeId { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [XmlElement("operating_dur")]
        public string OperatingDur { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("operating_scope")]
        public string OperatingScope { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        [XmlElement("operating_status")]
        public string OperatingStatus { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("record_authority")]
        public string RecordAuthority { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("reg_capital_pub")]
        public string RegCapitalPub { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 所属三级行业
        /// </summary>
        [XmlElement("third_level_industry")]
        public string ThirdLevelIndustry { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("unified_social_credit_code")]
        public string UnifiedSocialCreditCode { get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        [XmlElement("used_name")]
        public string UsedName { get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [XmlElement("website")]
        public string Website { get; set; }
    }
}
