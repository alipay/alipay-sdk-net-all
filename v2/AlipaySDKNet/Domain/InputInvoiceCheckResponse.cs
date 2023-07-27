using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceCheckResponse Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceCheckResponse : AopObject
    {
        /// <summary>
        /// 购方地址电话
        /// </summary>
        [XmlElement("buyer_address_phone")]
        public string BuyerAddressPhone { get; set; }

        /// <summary>
        /// 购方银行信息
        /// </summary>
        [XmlElement("buyer_bank_info")]
        public string BuyerBankInfo { get; set; }

        /// <summary>
        /// 购方公司名称
        /// </summary>
        [XmlElement("buyer_company_name")]
        public string BuyerCompanyName { get; set; }

        /// <summary>
        /// 购方ouCode
        /// </summary>
        [XmlElement("buyer_ou_code")]
        public string BuyerOuCode { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 作废标识
        /// </summary>
        [XmlElement("cancellation_mark")]
        public string CancellationMark { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("drawer")]
        public string Drawer { get; set; }

        /// <summary>
        /// Y:全电,N:非全电
        /// </summary>
        [XmlElement("full_electronic_flag")]
        public string FullElectronicFlag { get; set; }

        /// <summary>
        /// 发票行
        /// </summary>
        [XmlArray("input_invoice_check_line")]
        [XmlArrayItem("input_invoice_check_line")]
        public List<InputInvoiceCheckLine> InputInvoiceCheckLine { get; set; }

        /// <summary>
        /// 价税合计,单位元,两位小数
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("invoice_remark")]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// 01:专票,02:普票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// ofd文件下载链接
        /// </summary>
        [XmlElement("ofd_url")]
        public string OfdUrl { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// pdf文件下载链接
        /// </summary>
        [XmlElement("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("reviewer")]
        public string Reviewer { get; set; }

        /// <summary>
        /// 销方地址电话
        /// </summary>
        [XmlElement("seller_address_phone")]
        public string SellerAddressPhone { get; set; }

        /// <summary>
        /// 销方银行信息
        /// </summary>
        [XmlElement("seller_bank_info")]
        public string SellerBankInfo { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 税额,单位元,两位小数
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }
    }
}
