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
        /// 复核人
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 开票员姓名，用户可自助选择开票员传入，开票员姓名，证件类型，证件号码，必须同时存在，同时为空。 用户传入的开票员将会校验其合法性（开票员是否授权开票）
        /// </summary>
        [XmlElement("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 开票员证件号码
        /// </summary>
        [XmlElement("clerk_cert_no")]
        public string ClerkCertNo { get; set; }

        /// <summary>
        /// 开票员证件类型
        /// </summary>
        [XmlElement("clerk_cert_type")]
        public string ClerkCertType { get; set; }

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
        /// 购买方自然人证件号码
        /// </summary>
        [XmlElement("nature_person_cert_no")]
        public string NaturePersonCertNo { get; set; }

        /// <summary>
        /// 购买方自然人身份证件类型 更多枚举详情见： <a href="https://opendocs.alipay.com/mini/0i32us">https://opendocs.alipay.com/mini/0i32us</a>
        /// </summary>
        [XmlElement("nature_person_cert_type")]
        public string NaturePersonCertType { get; set; }

        /// <summary>
        /// 当“自然人证件类型”选择“居民身份证”时，校验是否为“中国”; 当“自然人证件类型”选择“港澳居民来往内地通行证”时，如果“证件号码 ”以H开头，“国籍(或地区)”必须为“中国香港”;如果“证件号码”以M开头，“国籍 (或地区)”必须为“中国澳门”;校验证件号码必须以H或M开头。  当“自然人证件类型”选择“台湾居民来往大陆通行证”时，校验是否为 “中国台湾”。 当“自然人证件类型”选择“中华人民共和国护照”时，校验是否为“中国”。  当“自然人证件类型”选择“中华人民共和国港澳居民居住证”时，校验证件 号码必须以810000或820000开头，如果“证件号码”以810000开头，“国籍(或地区)”必须为 “中国香港”;如果“证件号码”以820000开头，“国籍(或地区)”必须为“中国澳门 ”; 当“自然人证件类型”选择“中华人民共和国台湾居民居住证”时，校验是否为“中国台湾”。  更多枚举详情见：<a href="https://opendocs.alipay.com/mini/0i32us">https://opendocs.alipay.com/mini/0i32us</a>
        /// </summary>
        [XmlElement("nature_person_country")]
        public string NaturePersonCountry { get; set; }

        /// <summary>
        /// 购买方自然人标志为N时，购买方信息（ (购买方)自然人国籍代码、(购买方)自然人证件类型、(购买方)自然人证件号码)）必须为空 购买方自然人标志为Y时，若“(购买方)自然人证件类型”填写“居民身份证”，购买方纳税人识别号必须与(购买方)自然人证件号码完全一致
        /// </summary>
        [XmlElement("nature_person_flag")]
        public string NaturePersonFlag { get; set; }

        /// <summary>
        /// 外部开票申请ID
        /// </summary>
        [XmlElement("outer_apply_id")]
        public string OuterApplyId { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

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
        /// 销售方地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销售方银行卡账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销售方开户行
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [XmlElement("seller_tel")]
        public string SellerTel { get; set; }

        /// <summary>
        /// 是否展示购买方方银行信息 字段值为Y，则会在发票上展示购买方的银行信息（购买方开户行，购买方银行卡账号），不填默认为N
        /// </summary>
        [XmlElement("show_buyer_bank_info")]
        public string ShowBuyerBankInfo { get; set; }

        /// <summary>
        /// 是否展示销售方银行信息 字段值为Y，则会在发票上展示销售方的银行信息（销售方开户行，销售方银行卡账号），不填默认为N
        /// </summary>
        [XmlElement("show_seller_bank_info")]
        public string ShowSellerBankInfo { get; set; }

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
