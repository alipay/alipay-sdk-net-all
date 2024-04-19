using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinCustomerMemberCreateModel : AopObject
    {
        /// <summary>
        /// 认证方式（NONE:不认证）
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 业务线（LOGISTICS_FIN-物流金融，SHIPPING_EBL-电子提单）
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 企业相关数据
        /// </summary>
        [XmlElement("company_info")]
        public DefiCustCompanyDTO CompanyInfo { get; set; }

        /// <summary>
        /// did
        /// </summary>
        [XmlElement("did")]
        public string Did { get; set; }

        /// <summary>
        /// 会员类型（ENTERPRISE-企业，INDIVIDUAL-个人）
        /// </summary>
        [XmlElement("member_type")]
        public string MemberType { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("role_types")]
        [XmlArrayItem("string")]
        public List<string> RoleTypes { get; set; }

        /// <summary>
        /// 商业中台租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
