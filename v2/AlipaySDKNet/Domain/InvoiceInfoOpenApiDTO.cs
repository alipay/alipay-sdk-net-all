using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceInfoOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceInfoOpenApiDTO : AopObject
    {
        /// <summary>
        /// 银行账号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司code
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 注册电话
        /// </summary>
        [XmlElement("registered_phone_no")]
        public string RegisteredPhoneNo { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人类型
        /// </summary>
        [XmlElement("taxpayer_type")]
        public string TaxpayerType { get; set; }
    }
}
