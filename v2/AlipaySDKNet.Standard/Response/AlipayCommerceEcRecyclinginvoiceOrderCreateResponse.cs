using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 收款即开票页面支付宝URL（自然人端） 在支付宝里打开的自然人缴税并收款页面，可从企业（商户）/服务商自有APP/小程序页面打开 供应商ID存在值时返回 未安装支付宝或使用受限目标容器时可能无法打开
        /// </summary>
        [XmlElement("collection_invoice_page_alipay_url")]
        public string CollectionInvoicePageAlipayUrl { get; set; }

        /// <summary>
        /// 收款即开票页面URL（自然人端） 在支付宝里打开的自然人缴税并收款页面，可从企业（商户）/服务商自有APP/小程序页面打开 供应商ID传值时返回
        /// </summary>
        [XmlElement("collection_invoice_page_url")]
        public string CollectionInvoicePageUrl { get; set; }

        /// <summary>
        /// 订单的备注字段,用于发票的备注显示
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 支付即开票页面支付宝URL（营业员端） 在支付宝里打开的营业员端页面，若营业员未登录过支付宝反向开票小程序，需先打开登录页 未安装支付宝或使用受限目标容器时可能无法打开
        /// </summary>
        [XmlElement("payment_invoice_page_alipay_url")]
        public string PaymentInvoicePageAlipayUrl { get; set; }

        /// <summary>
        /// 支付即开票页面URL（营业员端） 在支付宝里打开的营业员端页面，若营业员未登录过支付宝反向开票小程序，需先打开登录页
        /// </summary>
        [XmlElement("payment_invoice_page_url")]
        public string PaymentInvoicePageUrl { get; set; }

        /// <summary>
        /// 支付即开票二维码URL（营业员端） 可以嵌入在企业（商户）/服务商自有APP/小程序页面中的二维码，供自然人扫码 该二维码链接有效期和反向开票助手小程序中刷新时间（5分钟）保持一致
        /// </summary>
        [XmlElement("payment_invoice_qr_code_url")]
        public string PaymentInvoiceQrCodeUrl { get; set; }

        /// <summary>
        /// 税务机关监管提醒
        /// </summary>
        [XmlElement("tax_authority_remind")]
        public string TaxAuthorityRemind { get; set; }
    }
}
