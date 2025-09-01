using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInvoiceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInvoiceInfoDTO : AopObject
    {
        /// <summary>
        /// 防伪码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 发票归集来源
        /// </summary>
        [XmlElement("collect_source")]
        public string CollectSource { get; set; }

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
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 特定行业信息，需要根据特定行业要素类型（specific_factor），获取<a href="https://opendocs.alipay.com/pre-open/07wr4t?pathHash=5d7c31e5#%E8%A1%8C%E4%B8%9A%E6%A8%A1%E5%9E%8B%E5%AE%9A%E4%B9%89">具体行业模型</a>
        /// </summary>
        [XmlArray("industry_specific_infos")]
        [XmlArrayItem("string")]
        public List<string> IndustrySpecificInfos { get; set; }

        /// <summary>
        /// 发票查验结果
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
        /// 发票明细列表
        /// </summary>
        [XmlArray("invoice_item_list")]
        [XmlArrayItem("enterprise_invoice_item_d_t_o")]
        public List<EnterpriseInvoiceItemDTO> InvoiceItemList { get; set; }

        /// <summary>
        /// 发票类型
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
        /// 发票类型
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
        /// 销方银行账户
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
        /// 是否关联到账单
        /// </summary>
        [XmlElement("related_to_consume")]
        public bool RelatedToConsume { get; set; }

        /// <summary>
        /// 特定行业要素类型
        /// </summary>
        [XmlElement("specific_factor")]
        public string SpecificFactor { get; set; }

        /// <summary>
        /// 发票金额，价税合计金额，单位元
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
