using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TpaBillDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TpaBillDataDTO : AopObject
    {
        /// <summary>
        /// 账单理赔状态 CREATED 创建 CANCLE 取消
        /// </summary>
        [XmlElement("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 理赔申请书
        /// </summary>
        [XmlElement("claim_application_form_url")]
        public string ClaimApplicationFormUrl { get; set; }

        /// <summary>
        /// 理赔单号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 理赔类型
        /// </summary>
        [XmlElement("claim_type")]
        public string ClaimType { get; set; }

        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("code_value")]
        public string CodeValue { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 医院门店编号
        /// </summary>
        [XmlElement("hospital_branch_code")]
        public string HospitalBranchCode { get; set; }

        /// <summary>
        /// 医院门店名称
        /// </summary>
        [XmlElement("hospital_branch_name")]
        public string HospitalBranchName { get; set; }

        /// <summary>
        /// 医院Code
        /// </summary>
        [XmlElement("hospital_code")]
        public string HospitalCode { get; set; }

        /// <summary>
        /// 医院名
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 个单号
        /// </summary>
        [XmlElement("policy_id")]
        public string PolicyId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 就诊时间
        /// </summary>
        [XmlElement("visit_time")]
        public string VisitTime { get; set; }
    }
}
