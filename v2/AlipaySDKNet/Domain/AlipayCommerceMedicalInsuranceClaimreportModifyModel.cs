using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceClaimreportModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceClaimreportModifyModel : AopObject
    {
        /// <summary>
        /// 账号信息
        /// </summary>
        [XmlElement("account_info")]
        public PolicyAccountInfoModel AccountInfo { get; set; }

        /// <summary>
        /// 保司理赔申请号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 支付宝生成的业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否是赔案重开
        /// </summary>
        [XmlElement("case_reopened")]
        public bool CaseReopened { get; set; }

        /// <summary>
        /// 理赔撤销状态下，结算数据是否允许重新提交
        /// </summary>
        [XmlElement("case_setl_reapply")]
        public bool CaseSetlReapply { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// ?户证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 理赔详情结构化数据字符串，用于支付宝商保码前端用户展示
        /// </summary>
        [XmlElement("claim_detail")]
        public string ClaimDetail { get; set; }

        /// <summary>
        /// claim_no 保司报案号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔关联保单号列表
        /// </summary>
        [XmlArray("claim_rel_policy_no_list")]
        [XmlArrayItem("string")]
        public List<string> ClaimRelPolicyNoList { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 申请材料
        /// </summary>
        [XmlArray("identity_materials")]
        [XmlArrayItem("identity_materials")]
        public List<IdentityMaterials> IdentityMaterials { get; set; }

        /// <summary>
        /// 补材场景
        /// </summary>
        [XmlElement("lack_materials_sense")]
        public string LackMaterialsSense { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 理赔通知书获取类型
        /// </summary>
        [XmlElement("note_type")]
        public string NoteType { get; set; }

        /// <summary>
        /// 理赔通知书
        /// </summary>
        [XmlElement("note_url")]
        public string NoteUrl { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 立案失败原因或拒赔原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 支付宝生成的流水号
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 结算信息列表
        /// </summary>
        [XmlArray("selt_info_list")]
        [XmlArrayItem("selt_info_list")]
        public List<SeltInfoList> SeltInfoList { get; set; }

        /// <summary>
        /// 交易来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 理赔总金额，单位：元
        /// </summary>
        [XmlElement("total_claim_amount")]
        public string TotalClaimAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
