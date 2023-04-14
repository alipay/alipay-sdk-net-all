using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierInfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierInfoQueryResponse : AopResponse
    {
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
        /// 经营范围
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        [XmlElement("charge_person_name")]
        public string ChargePersonName { get; set; }

        /// <summary>
        /// 负责人类型，例如：法定代表人、法人代表、执行合伙人等
        /// </summary>
        [XmlElement("charge_person_type")]
        public string ChargePersonType { get; set; }

        /// <summary>
        /// 企业从业人数
        /// </summary>
        [XmlElement("employee_account")]
        public string EmployeeAccount { get; set; }

        /// <summary>
        /// 企业分支机构列表信息
        /// </summary>
        [XmlArray("ep_branch_list")]
        [XmlArrayItem("ep_branch_info")]
        public List<EpBranchInfo> EpBranchList { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 经营状态，如存续、在业、吊销、注销、迁入、迁出等
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ep_type")]
        public string EpType { get; set; }

        /// <summary>
        /// 企业类别范围: ENTERPRISE(企业)， INDIVIDUAL（个体工商户), ORGANIZATION(组织机构)
        /// </summary>
        [XmlElement("ep_type_scope")]
        public string EpTypeScope { get; set; }

        /// <summary>
        /// 成立时间
        /// </summary>
        [XmlElement("established_time")]
        public string EstablishedTime { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("registered_capital")]
        public string RegisteredCapital { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("registered_org")]
        public string RegisteredOrg { get; set; }

        /// <summary>
        /// 公开社保缴纳员工数
        /// </summary>
        [XmlElement("social_security_account")]
        public string SocialSecurityAccount { get; set; }
    }
}
