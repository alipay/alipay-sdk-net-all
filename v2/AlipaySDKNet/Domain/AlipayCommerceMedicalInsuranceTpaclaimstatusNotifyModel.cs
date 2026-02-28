using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTpaclaimstatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceTpaclaimstatusNotifyModel : AopObject
    {
        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 支付宝业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 投保人证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 投保人姓名证件类型·
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 示例：100.00 单位：元 保留俩位小数
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 理赔申请书业务单号
        /// </summary>
        [XmlElement("claim_application_biz_no")]
        public string ClaimApplicationBizNo { get; set; }

        /// <summary>
        /// 理赔申请书
        /// </summary>
        [XmlElement("claim_application_form_url")]
        public string ClaimApplicationFormUrl { get; set; }

        /// <summary>
        /// 理赔单号（风石）
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔通知书
        /// </summary>
        [XmlElement("claim_note_url")]
        public string ClaimNoteUrl { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 示例：100.00 单位：元 保留俩位小数
        /// </summary>
        [XmlElement("direct_pay_quota")]
        public string DirectPayQuota { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("dplan_code")]
        public string DplanCode { get; set; }

        /// <summary>
        /// 产品名
        /// </summary>
        [XmlElement("dplan_name")]
        public string DplanName { get; set; }

        /// <summary>
        /// 被保人证件号
        /// </summary>
        [XmlElement("insured_cert_no")]
        public string InsuredCertNo { get; set; }

        /// <summary>
        /// 被保人证件类型
        /// </summary>
        [XmlElement("insured_cert_type")]
        public string InsuredCertType { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("insured_name")]
        public string InsuredName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("insurance_material_info")]
        public List<InsuranceMaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 投保人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 申请人支付宝支付宝openid 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pre_auth_info_list")]
        [XmlArrayItem("insurance_pre_auth_info")]
        public List<InsurancePreAuthInfo> PreAuthInfoList { get; set; }

        /// <summary>
        /// 立案失败原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// tpa编号
        /// </summary>
        [XmlElement("tpa_id")]
        public string TpaId { get; set; }

        /// <summary>
        /// 申请人支付宝user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 就诊信息
        /// </summary>
        [XmlElement("visit_info")]
        public InsuranceVisitInfo VisitInfo { get; set; }
    }
}
