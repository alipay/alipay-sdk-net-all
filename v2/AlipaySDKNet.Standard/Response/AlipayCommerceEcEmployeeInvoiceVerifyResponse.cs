using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInvoiceVerifyResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInvoiceVerifyResponse : AopResponse
    {
        /// <summary>
        /// 防伪码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 发票下载地址
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件类型： jpg:发票图片;pdf:发票PDF文件;
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 发票查验结果: INVOICE_CORRECT:发票正确;INVOICE_MISTAKE:发票信息错误;INVOICE_HAS_RED_INVOICE:发票存在红冲;INVOICE_CANCELLED:发票已作废
        /// </summary>
        [XmlElement("invoice_check_result")]
        public string InvoiceCheckResult { get; set; }

        /// <summary>
        /// 发票查验时间
        /// </summary>
        [XmlElement("invoice_check_time")]
        public string InvoiceCheckTime { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票种类: E_SPECIALTY:增值税电子专用发票; E_PLAN:增值税电子普通发票;ALL_ELECTRONIC_SPECIAL:电子发票(增值税专用发票);ALL_ELECTRONIC_GENERAL:电子发票(普通发票);SPECIAL:增值税专用发票;PLAIN_INVOICE:增值税普通发票
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票类型 值有两种情况：blue－蓝票 red－红票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 销方地址
        /// </summary>
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("payee_bank_account")]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销方开户行
        /// </summary>
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销方电话
        /// </summary>
        [XmlElement("payee_mobile")]
        public string PayeeMobile { get; set; }

        /// <summary>
        /// 销方抬头
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购方地址
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("payer_mobile")]
        public string PayerMobile { get; set; }

        /// <summary>
        /// 购方抬头
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 发票金额，单位元
        /// </summary>
        [XmlElement("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 税额，单位元
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额，单位元
        /// </summary>
        [XmlElement("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
