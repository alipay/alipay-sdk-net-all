using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisterApplyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RegisterApplyInfoDTO : AopObject
    {
        /// <summary>
        /// 申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [XmlElement("enterprise_email")]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 审核通过后注册成功的企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 上级企业id
        /// </summary>
        [XmlElement("parent_enterprise_id")]
        public string ParentEnterpriseId { get; set; }
    }
}
