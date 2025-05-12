using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款即开票页面支付宝URL（自然人端） 在支付宝里打开的自然人缴税并收款页面，可从企业（商户）/服务商自有APP/小程序页面打开 供应商ID存在值时返回 未安装支付宝或使用受限目标容器时可能无法打开
        /// </summary>
        [XmlElement("collection_invoice_page_alipay_url")]
        public string CollectionInvoicePageAlipayUrl { get; set; }

        /// <summary>
        /// 收款即开票页面URL（自然人端） 在支付宝里打开的自然人缴税并收款页面，可从企业（商户）/服务商自有APP/小程序页面打开 供应商ID存在值时返回
        /// </summary>
        [XmlElement("collection_invoice_page_url")]
        public string CollectionInvoicePageUrl { get; set; }

        /// <summary>
        /// 企业（商户）营业员ID
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 企业（商户）供应商ID
        /// </summary>
        [XmlElement("company_supplier_id")]
        public string CompanySupplierId { get; set; }

        /// <summary>
        /// 交易成功时间
        /// </summary>
        [XmlElement("gmt_success")]
        public string GmtSuccess { get; set; }

        /// <summary>
        /// 订单金额（元，两位小数）
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单发票列表
        /// </summary>
        [XmlArray("order_invoice_list")]
        [XmlArrayItem("order_invoice")]
        public List<OrderInvoice> OrderInvoiceList { get; set; }

        /// <summary>
        /// 订单商品明细
        /// </summary>
        [XmlArray("order_item_list")]
        [XmlArrayItem("recyclinginvoice_order_item")]
        public List<RecyclinginvoiceOrderItem> OrderItemList { get; set; }

        /// <summary>
        /// 订单支付单
        /// </summary>
        [XmlElement("order_payment")]
        public OrderPayment OrderPayment { get; set; }

        /// <summary>
        /// 订单交易状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单缴税明细列表
        /// </summary>
        [XmlArray("order_tax_item_list")]
        [XmlArrayItem("order_tax")]
        public List<OrderTax> OrderTaxItemList { get; set; }

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
        /// 支付即开票二维码URL（营业员端） 可以嵌入在企业（商户）/服务商自有APP/小程序页面中的二维码，供自然人扫码 该二维码链接有效期和反向开票助手小程序中刷新时间（5分钟）保持一致，供应商ID存在时不返回
        /// </summary>
        [XmlElement("payment_invoice_qr_code_url")]
        public string PaymentInvoiceQrCodeUrl { get; set; }

        /// <summary>
        /// 发票产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 卖家名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 用于标记卖家支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 卖家手机号
        /// </summary>
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家用户ID
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 订单缴税总额（元，两位小数）
        /// </summary>
        [XmlElement("tax_total_amount")]
        public string TaxTotalAmount { get; set; }
    }
}
