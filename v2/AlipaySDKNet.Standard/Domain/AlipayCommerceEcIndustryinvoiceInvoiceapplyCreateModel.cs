using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceInvoiceapplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcIndustryinvoiceInvoiceapplyCreateModel : AopObject
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
        /// 商品明细列表，根据产品区分
        /// </summary>
        [XmlArray("invoice_item_list")]
        [XmlArrayItem("industry_invoice_item_info")]
        public List<IndustryInvoiceItemInfo> InvoiceItemList { get; set; }

        /// <summary>
        /// 发票票种
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 红冲原因
        /// </summary>
        [XmlElement("invoice_red_reason")]
        public string InvoiceRedReason { get; set; }

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
        /// 关联蓝票发票号码，开票类型为红票时必传，暂时仅支持全额红冲
        /// </summary>
        [XmlElement("related_blue_invoice_no")]
        public string RelatedBlueInvoiceNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 交易信息列表,当前仅支持单个交易,交易渠道仅支持支付宝-ALIPAY
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("industry_invoice_trade_info")]
        public List<IndustryInvoiceTradeInfo> TradeList { get; set; }
    }
}
