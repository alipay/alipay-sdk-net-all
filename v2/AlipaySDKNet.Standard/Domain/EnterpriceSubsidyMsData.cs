using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriceSubsidyMsData Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriceSubsidyMsData : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 报销理算业务流水号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 企补报销理算时间
        /// </summary>
        [XmlElement("claim_time")]
        public string ClaimTime { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业编号
        /// </summary>
        [XmlElement("cur_company_id")]
        public string CurCompanyId { get; set; }

        /// <summary>
        /// 上级企业编号
        /// </summary>
        [XmlElement("father_company_id")]
        public string FatherCompanyId { get; set; }

        /// <summary>
        /// 上级企业名称
        /// </summary>
        [XmlElement("father_company_name")]
        public string FatherCompanyName { get; set; }

        /// <summary>
        /// 就诊编号
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 定点医疗机构编码（H码）
        /// </summary>
        [XmlElement("medical_org_id")]
        public string MedicalOrgId { get; set; }

        /// <summary>
        /// 定点医疗机构名称
        /// </summary>
        [XmlElement("medical_org_name")]
        public string MedicalOrgName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付资金流水号（失败时不传）
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 医保就医支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 企补账户剩余金额
        /// </summary>
        [XmlElement("residue_amount")]
        public string ResidueAmount { get; set; }

        /// <summary>
        /// 医保结算单号
        /// </summary>
        [XmlElement("setl_id")]
        public string SetlId { get; set; }

        /// <summary>
        /// 本次企补报销总金额
        /// </summary>
        [XmlElement("total_claim_amount")]
        public string TotalClaimAmount { get; set; }
    }
}
