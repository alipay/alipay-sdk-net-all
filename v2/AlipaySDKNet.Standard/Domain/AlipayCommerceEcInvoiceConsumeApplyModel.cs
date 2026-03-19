using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceConsumeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceConsumeApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号，可通过查询企业码账单详情获取
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

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
        /// 购买方证件类型对应税号，根据购方提供的信息填写
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 付款方企业id，可通过查询入驻企业码企业详情获取
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("invoice_item_list")]
        [XmlArrayItem("invoice_merchant_item")]
        public List<InvoiceMerchantItem> InvoiceItemList { get; set; }

        /// <summary>
        /// 发票票种
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发起发票红冲原因
        /// </summary>
        [XmlElement("invoice_red_reason")]
        public string InvoiceRedReason { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 外部开票申请id，调用方自定义生成，且保证唯一
        /// </summary>
        [XmlElement("outer_apply_id")]
        public string OuterApplyId { get; set; }

        /// <summary>
        /// 发起发票红冲时对应原始蓝票的发票号码
        /// </summary>
        [XmlElement("related_blue_invoice_no")]
        public string RelatedBlueInvoiceNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 收款方企业id，可通过查询入驻企业码企业详情
        /// </summary>
        [XmlElement("seller_enterprise_id")]
        public string SellerEnterpriseId { get; set; }
    }
}
