using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBusinessBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBusinessBasicInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// A级纳税人评价年度
        /// </summary>
        [XmlArray("ajnsrpjnd")]
        [XmlArrayItem("string")]
        public List<string> Ajnsrpjnd { get; set; }

        /// <summary>
        /// 核准日期
        /// </summary>
        [XmlElement("approval_date")]
        public string ApprovalDate { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("build_date")]
        public string BuildDate { get; set; }

        /// <summary>
        /// 经营期限自
        /// </summary>
        [XmlElement("business_period_from")]
        public string BusinessPeriodFrom { get; set; }

        /// <summary>
        /// 经营期限至
        /// </summary>
        [XmlElement("business_period_to")]
        public string BusinessPeriodTo { get; set; }

        /// <summary>
        /// 注销日期
        /// </summary>
        [XmlElement("cancellation_date")]
        public string CancellationDate { get; set; }

        /// <summary>
        /// 首席代表
        /// </summary>
        [XmlElement("chief_representative")]
        public string ChiefRepresentative { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        [XmlElement("frdb")]
        public string Frdb { get; set; }

        /// <summary>
        /// 企业所属行业信息
        /// </summary>
        [XmlElement("industry_model")]
        public EpIndustryModel IndustryModel { get; set; }

        /// <summary>
        /// 投资人
        /// </summary>
        [XmlElement("investors")]
        public string Investors { get; set; }

        /// <summary>
        /// 经营场所
        /// </summary>
        [XmlElement("jycs")]
        public string Jycs { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("legal_representative")]
        public string LegalRepresentative { get; set; }

        /// <summary>
        /// 法代或执行
        /// </summary>
        [XmlElement("legal_representative_or_pe")]
        public string LegalRepresentativeOrPe { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("manager_scope")]
        public string ManagerScope { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 企业曾用名
        /// </summary>
        [XmlElement("old_name")]
        public string OldName { get; set; }

        /// <summary>
        /// 经营者
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 联系方式，电话或手机
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 省市
        /// </summary>
        [XmlElement("province_or_city")]
        public string ProvinceOrCity { get; set; }

        /// <summary>
        /// 迁入地工商局
        /// </summary>
        [XmlElement("qrdgsj")]
        public string Qrdgsj { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("registe_organ")]
        public string RegisteOrgan { get; set; }

        /// <summary>
        /// 登记状态
        /// </summary>
        [XmlElement("register_status")]
        public string RegisterStatus { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("registr_id")]
        public string RegistrId { get; set; }

        /// <summary>
        /// 注册资本（万元）
        /// </summary>
        [XmlElement("registration_capital")]
        public string RegistrationCapital { get; set; }

        /// <summary>
        /// 吊销日期
        /// </summary>
        [XmlElement("revocation_date")]
        public string RevocationDate { get; set; }

        /// <summary>
        /// 企业规范化名称
        /// </summary>
        [XmlElement("sanitized_name")]
        public string SanitizedName { get; set; }

        /// <summary>
        /// 派出企业名称
        /// </summary>
        [XmlElement("sent_company_name")]
        public string SentCompanyName { get; set; }

        /// <summary>
        /// 企业标准化名称
        /// </summary>
        [XmlElement("standardized_name")]
        public string StandardizedName { get; set; }

        /// <summary>
        /// 企业股票列表
        /// </summary>
        [XmlArray("stock")]
        [XmlArrayItem("ep_stock_info")]
        public List<EpStockInfo> Stock { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 企业类型代码
        /// </summary>
        [XmlElement("type_code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// 企业注册号或统一社会信用代码，一般为18位
        /// </summary>
        [XmlElement("tyshxydm")]
        public string Tyshxydm { get; set; }

        /// <summary>
        /// 注册资本币种
        /// </summary>
        [XmlElement("zczbbz")]
        public string Zczbbz { get; set; }

        /// <summary>
        /// 执行合伙人
        /// </summary>
        [XmlElement("zxhhr")]
        public string Zxhhr { get; set; }

        /// <summary>
        /// 执行事务合伙人
        /// </summary>
        [XmlElement("zxswhhr")]
        public string Zxswhhr { get; set; }

        /// <summary>
        /// 执行事务合伙人委派代表
        /// </summary>
        [XmlElement("zxswhhrwpdb")]
        public string Zxswhhrwpdb { get; set; }
    }
}
