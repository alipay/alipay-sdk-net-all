using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarLeasingOrder Data Structure.
    /// </summary>
    [Serializable]
    public class CarLeasingOrder : AopObject
    {
        /// <summary>
        /// 身份证号（支持AES加密）
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 车辆合格证（Vehicle Certificate of Conformity）文件链接（支持AES加密）
        /// </summary>
        [XmlElement("coc_file")]
        public string CocFile { get; set; }

        /// <summary>
        /// 企业名称（支持AES加密）
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 经销商企业名称（支持AES加密）
        /// </summary>
        [XmlElement("dealer_company_name")]
        public string DealerCompanyName { get; set; }

        /// <summary>
        /// 首付比例
        /// </summary>
        [XmlElement("down_payment_percent")]
        public long DownPaymentPercent { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("installment_periods")]
        public long InstallmentPeriods { get; set; }

        /// <summary>
        /// 保险保单文件链接（支持AES加密）
        /// </summary>
        [XmlElement("insurance_policy_file")]
        public string InsurancePolicyFile { get; set; }

        /// <summary>
        /// 发票文件链接（支持AES加密）
        /// </summary>
        [XmlElement("invoice_file")]
        public string InvoiceFile { get; set; }

        /// <summary>
        /// 法人代表身份证号（支持AES加密）
        /// </summary>
        [XmlElement("legal_representative_cert_no")]
        public string LegalRepresentativeCertNo { get; set; }

        /// <summary>
        /// 法人代表姓名（支持AES加密）
        /// </summary>
        [XmlElement("legal_representative_name")]
        public string LegalRepresentativeName { get; set; }

        /// <summary>
        /// 放款金额（单位：元，精确到分）
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 手机号（支持AES加密）
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名（支持AES加密）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 购销合同影像文件链接（支持AES加密）
        /// </summary>
        [XmlElement("sales_contract_file")]
        public string SalesContractFile { get; set; }

        /// <summary>
        /// 购销合同ID
        /// </summary>
        [XmlElement("sales_contract_id")]
        public string SalesContractId { get; set; }

        /// <summary>
        /// 统一社会信用代码（Unified Social Credit Code）（支持AES加密）
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 车型信息
        /// </summary>
        [XmlElement("veh_model")]
        public string VehModel { get; set; }

        /// <summary>
        /// 车辆价格（单位：元，精确到分）
        /// </summary>
        [XmlElement("veh_price")]
        public string VehPrice { get; set; }

        /// <summary>
        /// VIN码（支持AES加密）
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
