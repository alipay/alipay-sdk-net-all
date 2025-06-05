using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInfoDTO : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 因公签约状态
        /// </summary>
        [XmlElement("activate")]
        public string Activate { get; set; }

        /// <summary>
        /// 企业认证等级
        /// </summary>
        [XmlElement("auth_level")]
        public string AuthLevel { get; set; }

        /// <summary>
        /// 认证状态
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业简称审核状态 PASSED： 通过 REJECTED： 驳回 AUDITING： 审核中
        /// </summary>
        [XmlElement("enterprise_alias_audit_status")]
        public string EnterpriseAliasAuditStatus { get; set; }

        /// <summary>
        /// 统一社会信用码
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("enterprise_email")]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 封闭场景（如班车）的人脸库id
        /// </summary>
        [XmlElement("iot_group_id")]
        public string IotGroupId { get; set; }

        /// <summary>
        /// 开放场景（如团餐）的人脸库id
        /// </summary>
        [XmlElement("iot_logic_group_id")]
        public string IotLogicGroupId { get; set; }

        /// <summary>
        /// 外部平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 外部平台id
        /// </summary>
        [XmlElement("platform_out_id")]
        public string PlatformOutId { get; set; }

        /// <summary>
        /// 企业码服务协议签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 企业当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
