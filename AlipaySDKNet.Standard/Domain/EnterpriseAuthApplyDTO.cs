using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseAuthApplyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseAuthApplyDTO : AopObject
    {
        /// <summary>
        /// 企业认证申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 企业认证审核状态 AUDITING：审核中 REJECTED：已驳回 PASSED：已通过
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 企业认证申请记录id
        /// </summary>
        [XmlElement("auth_apply_id")]
        public string AuthApplyId { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业法人身份证号
        /// </summary>
        [XmlElement("legal_id_number")]
        public string LegalIdNumber { get; set; }

        /// <summary>
        /// 企业法人姓名
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照截止日期
        /// </summary>
        [XmlElement("license_end_date")]
        public string LicenseEndDate { get; set; }

        /// <summary>
        /// 营业执照图片文件url
        /// </summary>
        [XmlElement("license_img_url")]
        public string LicenseImgUrl { get; set; }
    }
}
