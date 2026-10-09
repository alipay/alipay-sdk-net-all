using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpCompanyVO Data Structure.
    /// </summary>
    [Serializable]
    public class CorpCompanyVO : AopObject
    {
        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("business_activities")]
        public string BusinessActivities { get; set; }

        /// <summary>
        /// 经营期限
        /// </summary>
        [XmlElement("business_period")]
        public string BusinessPeriod { get; set; }

        /// <summary>
        /// 公司维护人
        /// </summary>
        [XmlArray("company_maintainer")]
        [XmlArrayItem("opera_person_v_o")]
        public List<OperaPersonVO> CompanyMaintainer { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司英文名称
        /// </summary>
        [XmlElement("company_name_en")]
        public string CompanyNameEn { get; set; }

        /// <summary>
        /// 公司状态
        /// </summary>
        [XmlElement("company_status")]
        public string CompanyStatus { get; set; }

        /// <summary>
        /// 公司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 公司电话
        /// </summary>
        [XmlElement("contact_no")]
        public string ContactNo { get; set; }

        /// <summary>
        /// 董监高列表
        /// </summary>
        [XmlArray("corp_manager_list")]
        [XmlArrayItem("corp_manager_v_o")]
        public List<CorpManagerVO> CorpManagerList { get; set; }

        /// <summary>
        /// 股东列表
        /// </summary>
        [XmlArray("corp_shareholder_list")]
        [XmlArrayItem("corp_shareholder_v_o")]
        public List<CorpShareholderVO> CorpShareholderList { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlArray("currency")]
        [XmlArrayItem("currency_v_o")]
        public List<CurrencyVO> Currency { get; set; }

        /// <summary>
        /// 公司邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 提报时间
        /// </summary>
        [XmlElement("filing_annual_return_start_date")]
        public string FilingAnnualReturnStartDate { get; set; }

        /// <summary>
        /// 财政年度结算日
        /// </summary>
        [XmlElement("finance_year_settlement")]
        public string FinanceYearSettlement { get; set; }

        /// <summary>
        /// 成立地区
        /// </summary>
        [XmlElement("incorporation_area")]
        public string IncorporationArea { get; set; }

        /// <summary>
        /// 成立所在国
        /// </summary>
        [XmlElement("incorporation_country")]
        public string IncorporationCountry { get; set; }

        /// <summary>
        /// 公司成立日期
        /// </summary>
        [XmlElement("incorporation_date")]
        public string IncorporationDate { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("legal_person")]
        public PersonSimpleVO LegalPerson { get; set; }

        /// <summary>
        /// oucode
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        [XmlElement("parent_company")]
        public string ParentCompany { get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        [XmlElement("previous_name")]
        public string PreviousName { get; set; }

        /// <summary>
        /// 公司注册地址-省 市 区 信息
        /// </summary>
        [XmlElement("registered_address_format")]
        public RegisteredAddressVO RegisteredAddressFormat { get; set; }

        /// <summary>
        /// 公司英文注册地址
        /// </summary>
        [XmlElement("registered_office_address_en")]
        public string RegisteredOfficeAddressEn { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// 周年股东大会日期
        /// </summary>
        [XmlElement("shareholders_meeting_date")]
        public string ShareholdersMeetingDate { get; set; }
    }
}
