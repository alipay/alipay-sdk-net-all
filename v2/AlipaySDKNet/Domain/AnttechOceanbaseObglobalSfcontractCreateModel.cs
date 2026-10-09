using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfcontractCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfcontractCreateModel : AopObject
    {
        /// <summary>
        /// 合同申请人工号
        /// </summary>
        [XmlElement("applicant_work_no")]
        public string ApplicantWorkNo { get; set; }

        /// <summary>
        /// CSM审批人工号
        /// </summary>
        [XmlElement("audit_csm_work_no")]
        public string AuditCsmWorkNo { get; set; }

        /// <summary>
        /// 合同创建系统,OCEAN_BASE/ZHENLING
        /// </summary>
        [XmlElement("contract_create_system")]
        public string ContractCreateSystem { get; set; }

        /// <summary>
        /// 合同标题
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 合同类别枚举
        /// </summary>
        [XmlElement("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 外部系统合同id
        /// </summary>
        [XmlElement("external_contract_id")]
        public string ExternalContractId { get; set; }

        /// <summary>
        /// 最终管理员邮箱，来源为CONTRACT_AUTHORIZED时必填，否则可不传
        /// </summary>
        [XmlElement("final_admin_email")]
        public string FinalAdminEmail { get; set; }

        /// <summary>
        /// 最终管理员邮箱来源
        /// </summary>
        [XmlElement("final_admin_email_source_code")]
        public string FinalAdminEmailSourceCode { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// OB签约自身主体名称
        /// </summary>
        [XmlElement("our_sign_subject")]
        public string OurSignSubject { get; set; }

        /// <summary>
        /// 报价审批单号
        /// </summary>
        [XmlElement("quotation_application_item_no")]
        public string QuotationApplicationItemNo { get; set; }

        /// <summary>
        /// 幂等请求号；同一次请求重试必须保持一致
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
