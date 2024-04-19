using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceCompanyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceCompanyDTO : AopObject
    {
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
        /// 入驻商户的营业执照，图像二进制数据的base64编码
        /// </summary>
        [XmlElement("business_license_img")]
        public string BusinessLicenseImg { get; set; }

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
        /// 企业类型，可选值： 一般纳税人：1，小规模纳税人：2，起征点以下纳税人：3
        /// </summary>
        [XmlElement("company_type")]
        public long CompanyType { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("default_item_name")]
        public string DefaultItemName { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("default_tax_code")]
        public string DefaultTaxCode { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("default_tax_rate")]
        public string DefaultTaxRate { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 税盘
        /// </summary>
        [XmlArray("invoice_disks")]
        [XmlArrayItem("string")]
        public List<string> InvoiceDisks { get; set; }

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
        /// 开票人
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
        /// 企业所在省/直辖市
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 商户在税控服务开通后，税控厂商会向商户分配秘钥并提供token的生成方法，商户或ISV利用该方法生成token以获得此次调用的操作权限
        /// </summary>
        [XmlElement("tax_token")]
        public string TaxToken { get; set; }

        /// <summary>
        /// 0税率标识，可选值：出口零税率：0，免税：1，不征收：2，普通零税率：3
        /// </summary>
        [XmlElement("zero_tax_rate_flag")]
        public string ZeroTaxRateFlag { get; set; }
    }
}
