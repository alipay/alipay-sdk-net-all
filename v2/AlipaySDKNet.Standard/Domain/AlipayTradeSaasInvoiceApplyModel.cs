using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasInvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 发票购方信息
        /// </summary>
        [XmlElement("invoice_buyer_info")]
        public InvoiceBuyerInfo InvoiceBuyerInfo { get; set; }

        /// <summary>
        /// 发票交付信息
        /// </summary>
        [XmlElement("invoice_deliver_info")]
        public InvoiceDeliverInfo InvoiceDeliverInfo { get; set; }

        /// <summary>
        /// 发票开票人信息
        /// </summary>
        [XmlElement("invoice_issuer_info")]
        public InvoiceIssuerInfo InvoiceIssuerInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("invoice_items")]
        [XmlArrayItem("invoice_product_item_info")]
        public List<InvoiceProductItemInfo> InvoiceItems { get; set; }

        /// <summary>
        /// 发票主体信息
        /// </summary>
        [XmlElement("invoice_main_info")]
        public InvoiceMainInfo InvoiceMainInfo { get; set; }

        /// <summary>
        /// [{"SINGLE_INVOICE":"单次开票"},{"MERGE_INVOICE":"合并开票"}]
        /// </summary>
        [XmlElement("invoice_mode")]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 发票备注与展示控制
        /// </summary>
        [XmlElement("invoice_remark_info")]
        public InvoiceRemarkInfo InvoiceRemarkInfo { get; set; }

        /// <summary>
        /// 发票销方信息
        /// </summary>
        [XmlElement("invoice_seller_info")]
        public InvoiceSellerInfo InvoiceSellerInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("invoice_payment_info")]
        public List<InvoicePaymentInfo> OrderList { get; set; }

        /// <summary>
        /// 商户外部开票或红冲请求号，商户维度唯一
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 红票关联蓝票信息
        /// </summary>
        [XmlElement("red_related_invoice_info")]
        public RedRelatedInvoiceInfo RedRelatedInvoiceInfo { get; set; }
    }
}
