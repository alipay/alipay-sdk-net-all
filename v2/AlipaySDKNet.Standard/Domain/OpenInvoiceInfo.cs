using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenInvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenInvoiceInfo : AopObject
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 购方地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 原始文件/板式文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 发票图片预览地址
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 不含税开票金额
        /// </summary>
        [XmlElement("invoice_amount_without_tax")]
        public string InvoiceAmountWithoutTax { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票明细列表
        /// </summary>
        [XmlArray("invoice_item_list")]
        [XmlArrayItem("open_invoice_item")]
        public List<OpenInvoiceItem> InvoiceItemList { get; set; }

        /// <summary>
        /// 发票介质类型
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票标签
        /// </summary>
        [XmlElement("invoice_tag")]
        public string InvoiceTag { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("invoice_tax_amount")]
        public string InvoiceTaxAmount { get; set; }

        /// <summary>
        /// 发票税率
        /// </summary>
        [XmlElement("invoice_tax_rate")]
        public string InvoiceTaxRate { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 机器编码
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 原发票代码
        /// </summary>
        [XmlElement("original_invoice_code")]
        public string OriginalInvoiceCode { get; set; }

        /// <summary>
        /// 原发票号码
        /// </summary>
        [XmlElement("original_invoice_no")]
        public string OriginalInvoiceNo { get; set; }

        /// <summary>
        /// 密码区
        /// </summary>
        [XmlElement("password_area")]
        public string PasswordArea { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 二维码值
        /// </summary>
        [XmlElement("qr_code_text")]
        public string QrCodeText { get; set; }

        /// <summary>
        /// 冲红备注
        /// </summary>
        [XmlElement("red_remarks")]
        public string RedRemarks { get; set; }

        /// <summary>
        /// 销方地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方电话
        /// </summary>
        [XmlElement("seller_tel")]
        public string SellerTel { get; set; }

        /// <summary>
        /// 行程信息列表
        /// </summary>
        [XmlArray("travel_info_list")]
        [XmlArrayItem("open_invoice_travel_info")]
        public List<OpenInvoiceTravelInfo> TravelInfoList { get; set; }
    }
}
