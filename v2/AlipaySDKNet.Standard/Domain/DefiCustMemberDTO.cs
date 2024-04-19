using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DefiCustMemberDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DefiCustMemberDTO : AopObject
    {
        /// <summary>
        /// 企业认证状态 INIT("INIT", "初始状态"), AUTH("AUTH", "认证状态"),;
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 统一社会信用代码或者工商注册号
        /// </summary>
        [XmlElement("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// NATIONAL_LEGAL_MERGE("2011", " NATIONAL_LEGAL_MERGE", "全国法人营业执照(多证合一)", "全国法人营业执照(多证合一)"), NATIONAL_LEGAL("201", "NATIONAL_LEGAL", "全国法人营业执照", "全国法人营业执照"),
        /// </summary>
        [XmlElement("company_cert_type")]
        public string CompanyCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// ID映射
        /// </summary>
        [XmlElement("id_map")]
        public string IdMap { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("member_email")]
        public string MemberEmail { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 角色，支持多角色
        /// </summary>
        [XmlArray("role_types")]
        [XmlArrayItem("string")]
        public List<string> RoleTypes { get; set; }

        /// <summary>
        /// ACTIVE("ACTIVE", "激活状态"), FROZEN("FROZEN", "冻结状态"), DISABLED("DISABLED", "禁用状态"),;
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
