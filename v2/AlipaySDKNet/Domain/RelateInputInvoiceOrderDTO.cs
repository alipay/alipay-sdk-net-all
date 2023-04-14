using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelateInputInvoiceOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RelateInputInvoiceOrderDTO : AopObject
    {
        /// <summary>
        /// 发票附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 发票附件key
        /// </summary>
        [XmlElement("attachment_oss_key")]
        public string AttachmentOssKey { get; set; }

        /// <summary>
        /// 购方公司地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行名称
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方机构id
        /// </summary>
        [XmlElement("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// 购方发票抬头
        /// </summary>
        [XmlElement("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方公司电话
        /// </summary>
        [XmlElement("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 账单与发票关联信息
        /// </summary>
        [XmlArray("input_invoice_bill_link_order_list")]
        [XmlArrayItem("input_invoice_bill_link_order_d_t_o")]
        public List<InputInvoiceBillLinkOrderDTO> InputInvoiceBillLinkOrderList { get; set; }

        /// <summary>
        /// OU
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

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
        /// 发票行信息
        /// </summary>
        [XmlArray("invoice_line_orders")]
        [XmlArrayItem("ap_invoice_line_order_request")]
        public List<ApInvoiceLineOrderRequest> InvoiceLineOrders { get; set; }

        /// <summary>
        /// 发票介质 01 电子,02 纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 收票日期
        /// </summary>
        [XmlElement("invoice_receive_date")]
        public string InvoiceReceiveDate { get; set; }

        /// <summary>
        /// 发票来源 -01 手工输入 -02 扫描录入
        /// </summary>
        [XmlElement("invoice_source")]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票种类 01增值税专用发票 02增值税普通发票 03国际形式发票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 销方公司地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方公司名称
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 销方角色id
        /// </summary>
        [XmlElement("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }

        /// <summary>
        /// 销方mid
        /// </summary>
        [XmlElement("seller_mid")]
        public string SellerMid { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司电话
        /// </summary>
        [XmlElement("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 票面税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
