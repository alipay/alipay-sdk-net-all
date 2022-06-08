using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceDetailOutputQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceDetailOutputQueryResponse : AopResponse
    {
        /// <summary>
        /// 防伪码，发票校验码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 不含税金额（废弃）
        /// </summary>
        [XmlElement("ex_tax_amount")]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销
        /// </summary>
        [XmlElement("expense_status")]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 是否已上传发票pdf文件  false－未上传  true－已上传
        /// </summary>
        [XmlElement("has_upload_pdf")]
        public string HasUploadPdf { get; set; }

        /// <summary>
        /// 发票金额（价税合计金额）
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

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
        /// 发票缩略图地址
        /// </summary>
        [XmlElement("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票内容项
        /// </summary>
        [XmlArray("invoice_item_content_list")]
        [XmlArrayItem("invoice_item_content")]
        public List<InvoiceItemContent> InvoiceItemContentList { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态  SUCCEED－成功  EXPIRED－已失效  TRANSFERRED－已转交
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型  值有两种情况：blue－蓝票 red－红票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方开户银行账号
        /// </summary>
        [XmlElement("payee_bank_account")]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方开户银行名称
        /// </summary>
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [XmlElement("payee_phone")]
        public string PayeePhone { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [XmlElement("payee_register_name")]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [XmlElement("payee_tax_no")]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方开户银行账号
        /// </summary>
        [XmlElement("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户银行名称
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [XmlElement("payer_phone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购买方税号
        /// </summary>
        [XmlElement("payer_tax_no")]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// 合计税额（废弃）
        /// </summary>
        [XmlElement("sum_tax_amount")]
        public string SumTaxAmount { get; set; }

        /// <summary>
        /// 票种  PLAIN：增值税电子普通发票  SPECIAL：增值税专用发票  PLAIN_INVOICE:增值税普通发票  PAPER_INVOICE:增值税普通发票（卷式）  SALSE_INVOICE:机动车销售统一发票
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }
    }
}
