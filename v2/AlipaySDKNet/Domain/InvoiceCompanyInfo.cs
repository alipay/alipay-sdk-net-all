using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceCompanyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceCompanyInfo : AopObject
    {
        /// <summary>
        /// 发票限额信息，列表类型，按不同票种拆分发票限额
        /// </summary>
        [XmlArray("amount_limit_info")]
        [XmlArrayItem("invoice_amount_limit_info")]
        public List<InvoiceAmountLimitInfo> AmountLimitInfo { get; set; }

        /// <summary>
        /// 企业所在区
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("bank_account_id")]
        public string BankAccountId { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 企业所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业类型，可选值： 一般纳税人：1; 小规模纳税人：2; 起征点以下纳税人：3;
        /// </summary>
        [XmlElement("company_type")]
        public long CompanyType { get; set; }

        /// <summary>
        /// 默认商品名称
        /// </summary>
        [XmlElement("default_item_name")]
        public string DefaultItemName { get; set; }

        /// <summary>
        /// 默认税收分类编码
        /// </summary>
        [XmlElement("default_tax_code")]
        public string DefaultTaxCode { get; set; }

        /// <summary>
        /// 税率，格式为小数
        /// </summary>
        [XmlElement("default_tax_rate")]
        public string DefaultTaxRate { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 拓展字段, json格式
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 盘号，为列表类型
        /// </summary>
        [XmlArray("invoice_disks")]
        [XmlArrayItem("string")]
        public List<string> InvoiceDisks { get; set; }

        /// <summary>
        /// 税号可开发票类型，列表类型。 可选值： 增值税电子普通发票：PLAIN, 增值税专用发票：SPECIAL， 增值税普通发票：PLAIN_INVOICE，增值税普通发票(卷式)：PAPER_INVOICE
        /// </summary>
        [XmlArray("invoice_kinds")]
        [XmlArrayItem("string")]
        public List<string> InvoiceKinds { get; set; }

        /// <summary>
        /// 企业电话
        /// </summary>
        [XmlElement("invoice_phone")]
        public string InvoicePhone { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("payee_checker")]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 默认开票人
        /// </summary>
        [XmlElement("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee_receiver")]
        public string PayeeReceiver { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 税控服务商，由服务商在中台入驻后生成
        /// </summary>
        [XmlElement("provider_key")]
        public string ProviderKey { get; set; }

        /// <summary>
        /// 企业所在省/直辖市
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 产品类型，产品码由中台定义。 对应支付宝开票系统中的 productCode, 默认为DOCK_TAX_OPEN 税控托管产品
        /// </summary>
        [XmlElement("tax_feature")]
        public string TaxFeature { get; set; }

        /// <summary>
        /// 商户在税控服务开通后，税控厂商会向商户分配秘钥并提供token的生成方法，商户或ISV利用该方法生成token以获得此次调用的操作权限。 目前对于阿里平台来说，不需要校验该权限，如果底层税控对接的是阿里平台的话，该字段可不填，其它的税控厂商该字段为必填。 register_type=init时候必填
        /// </summary>
        [XmlElement("tax_token")]
        public string TaxToken { get; set; }
    }
}
