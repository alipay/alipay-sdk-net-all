using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceInvoiceapplyQueryResponse.
    /// </summary>
    public class AlipayCommerceEcIndustryinvoiceInvoiceapplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 购买方地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户行
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购买方证件类型对应税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购买方证件类型
        /// </summary>
        [XmlElement("buyer_tax_no_type")]
        public string BuyerTaxNoType { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 发票文件地址-图片
        /// </summary>
        [XmlElement("img_file_url")]
        public string ImgFileUrl { get; set; }

        /// <summary>
        /// 发票总金额，单位：元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票不含税金额
        /// </summary>
        [XmlElement("invoice_amount_without_tax")]
        public string InvoiceAmountWithoutTax { get; set; }

        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("invoice_apply_id")]
        public string InvoiceApplyId { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 开票异常错误码
        /// </summary>
        [XmlElement("invoice_fail_code")]
        public string InvoiceFailCode { get; set; }

        /// <summary>
        /// 开票异常错误说明
        /// </summary>
        [XmlElement("invoice_fail_desc")]
        public string InvoiceFailDesc { get; set; }

        /// <summary>
        /// 商品明细列表
        /// </summary>
        [XmlArray("invoice_item_list")]
        [XmlArrayItem("industry_invoice_item_info_query_res")]
        public List<IndustryInvoiceItemInfoQueryRes> InvoiceItemList { get; set; }

        /// <summary>
        /// 发票票种
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 红冲原因
        /// </summary>
        [XmlElement("invoice_red_reason")]
        public string InvoiceRedReason { get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票税额
        /// </summary>
        [XmlElement("invoice_tax_amount")]
        public string InvoiceTaxAmount { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 外部开票申请ID
        /// </summary>
        [XmlElement("outer_apply_id")]
        public string OuterApplyId { get; set; }

        /// <summary>
        /// 发票文件地址_PDF
        /// </summary>
        [XmlElement("pdf_file_url")]
        public string PdfFileUrl { get; set; }

        /// <summary>
        /// 发票产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 不动产信息列表
        /// </summary>
        [XmlArray("real_property_business_list")]
        [XmlArrayItem("industry_invoice_real_property_business")]
        public List<IndustryInvoiceRealPropertyBusiness> RealPropertyBusinessList { get; set; }

        /// <summary>
        /// 关联蓝票发票号码
        /// </summary>
        [XmlElement("related_blue_invoice_no")]
        public string RelatedBlueInvoiceNo { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 交易信息列表
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("industry_invoice_trade_info")]
        public List<IndustryInvoiceTradeInfo> TradeList { get; set; }
    }
}
